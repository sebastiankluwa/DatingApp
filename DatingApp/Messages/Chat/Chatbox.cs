using Local.DTOs.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Local.Messages.Chat
{
	public partial class Chatbox : UserControl
	{
        public ChatboxInfo chatbox_info;
        private readonly IContainer _container;
        public OpenFileDialog fileDialog = new OpenFileDialog();
        public string initialdirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public List<MessageDto> Messages { get; set; }

        public Chatbox(ChatboxInfo _chatbox_info, IContainer container)
        {
            InitializeComponent();

            chatbox_info = _chatbox_info;
            _container = container;
            clientnameLabel.Text = chatbox_info.NamePlaceholder;
            statusLabel.Text = chatbox_info.StatusPlaceholder;
            phoneLabel.Text = chatbox_info.PhonePlaceholder;
            chatTextbox.Text = chatbox_info.ChatPlaceholder;

            chatTextbox.Enter += ChatEnter;
            chatTextbox.Leave += ChatLeave;
            sendButton.Click += SendMessage;
            attachButton.Click += BuildAttachment;
            removeButton.Click += CancelAttachment;

            chatTextbox.KeyDown += OnEnter;

            Messages = new List<MessageDto>();
        }

        /// <summary>
        /// ChatItem objects are generated dynamically from IChatModel. By default, a ChatItem is allowed to be resized up to 60% of the entire screen.
        /// I've thought about it being editable from outside, but there's no real need to.
        /// </summary>
        /// <param name="message"></param>
        public void AddMessage(IChatModel message, MessageDto messageDto)
        {
            if(!Messages.Contains(messageDto))
            {
                Messages.Add(messageDto);

                var chatItem = new ChatItem(message);
                //chatItem.Name = "chatItem" + itemsPanel.Controls.Count;
                chatItem.Name = "chatItem" + messageDto.Id;
                //chatItem.Dock = DockStyle.Top;
                chatItem.Width = (int)(itemsPanel.Width - 25);

                itemsPanel.Controls.Add(chatItem);

                chatItem.BringToFront();
                chatItem.ResizeBubbles((int)(itemsPanel.Width * 0.6));

                SortControlsByOrderedMessageList(itemsPanel.Controls);

                var control = itemsPanel.Controls[GetLastItemIndex(itemsPanel.Controls)];

                itemsPanel.ScrollControlIntoView(control);
            }
        }

        public bool RemoveMessage(MessageDto message)
        {
            if (!Messages.Remove(message))
                return false;

            var control = itemsPanel.Controls.Find("chatItem" + message.Id, true).FirstOrDefault();
            itemsPanel.Controls.Remove(control);

            return true;
        }

        public void ClearMessages()
        {
            Messages.Clear();
            itemsPanel.Controls.Clear();
        }

        private int GetLastItemIndex(ControlCollection controls)
        {
            return controls.Count - 1;
        }

        private void SortControlsByOrderedMessageList(ControlCollection controls)
        {
            var messages = Messages.OrderBy(x => x.MessageSent).ToList();
            foreach (var message in messages.Select((value, i) => (value, i)))
            {
                var controlName = "chatItem" + message.value.Id;
                var control = controls.Find(controlName, true).First();
                controls.SetChildIndex(control, message.i);
            }
        }

        //Improves the chat UI slightly by having a placeholder text. Note that this is implemented because Winforms doesn't have a native "placeholder" UI. Can be buggy.
        void ChatLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(chatTextbox.Text))
            {
                chatTextbox.Text = chatbox_info.ChatPlaceholder;
                chatTextbox.ForeColor = Color.Gray;
            }
        }

        //Improves the chat UI slightly by having a placeholder text. Note that this is implemented because Winforms doesn't have a native "placeholder" UI. Can be buggy.
        void ChatEnter(object sender, EventArgs e)
        {
            chatTextbox.ForeColor = Color.Black;
            if (chatTextbox.Text == chatbox_info.ChatPlaceholder)
            {
                chatTextbox.Text = "";
            }
        }

        //Cross-tested this with the Twilio API and the RingCentral API, and async messaging is the way to go.
        async void SendMessage(object sender, EventArgs e)
        {
            string chatmessage = chatTextbox.Text;

            _container.MessageService.SendMessage(chatbox_info.OtherUsername, chatmessage);
        }

        void BuildAttachment(object sender, EventArgs e)
        {
            fileDialog.InitialDirectory = initialdirectory;
            fileDialog.Reset();
            fileDialog.Multiselect = false;

            var result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selected = fileDialog.FileName;
                try
                {
                    var file = File.ReadAllBytes(selected);
                    //Limits the size of the attachment to 1.45 MB, which is less than the max possible size of an SMS attachment of 1.5 MB.
                    if (file.Length > 1450000)
                    {
                        MessageBox.Show("The attachment provided " + fileDialog.SafeFileName + " is too big to be sent by SMS. Please select another.", "Attachment not added.");
                        return;
                    }
                    else
                    {
                        chatbox_info.Attachment = file;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("There was an issue with retrieving the file.", "File Operation Error");
                }
            }
            else
            {
                return;
            }

            if (chatbox_info.Attachment != null)
            {
                string smallname = fileDialog.SafeFileName;
                chatbox_info.AttachmentName = fileDialog.SafeFileName;

                string name = Path.GetFileNameWithoutExtension(smallname);
                string extension = Path.GetExtension(smallname);
                if (smallname.Length > 12)
                {
                    smallname = name.Substring(0, 7) + ".." + extension;
                    attachButton.Text = smallname;
                }
                else
                {
                    attachButton.Text = smallname;
                }

                removeButton.Visible = true;
                attachButton.Width = 115;
                chatbox_info.AttachmentType = ChatUtility.GetMimeType(extension);
            }
        }

        void CancelAttachment(object sender, EventArgs e)
        {
            attachButton.Text = string.Empty;
            chatbox_info.Attachment = null;
            chatbox_info.AttachmentName = null;
            chatbox_info.AttachmentType = null;
            removeButton.Visible = false;
            attachButton.Width = 35;
        }

        //Inspired from Slack, you can also press Shift + Enter to enter text.
        async void OnEnter(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyValue == 13)
            {
                SendMessage(this, null);
            }
        }

        //When the Control resizes, it will trigger the resize event for all the ChatItem object inside as well, again with a default width of 60%.
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            foreach (var control in itemsPanel2.Controls)
            {
                if (control is ChatItem)
                {
                    (control as ChatItem).ResizeBubbles((int)(itemsPanel2.Width * 0.6));
                }
            }
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
