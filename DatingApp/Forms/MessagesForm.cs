using DatingApp.App.Messages;
using DatingApp.App.Utils;
using Local;
using Local.DTOs.Messages;
using Local.Managers;
using Local.Messages.Chat;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatingApp.App.Forms
{
    public partial class MessagesForm : Form
    {
        private readonly Local.IContainer _container;
        private HubConnection _connection;
        private List<MessageDto> messages;
        ObservableCollection<MessageDto> MessagesList { get; set; }
        public List<MessageDto> MessageInboxOutbox { get; set; }
        private Chatbox _chatBox;


        public MessagesForm(Local.IContainer container)
        {
            _container = container;
            MessageInboxOutbox = new List<MessageDto>();
            MessagesList = new ObservableCollection<MessageDto>();
            MessagesList.CollectionChanged += updateView;
            InitializeComponent();
            connectToInboxMessagesHub();
            this.FormClosing += MessagesForm_Closing;
            _container.MessageService.MessageThread.CollectionChanged += updateMessageThread;
        }

        public void EnterChatWith(string username)
        {
            if (_container.MessageService.IsConnectionToMessageHub())
            {
                _container.MessageService.DisconnectFromMessageHub();
                panelMessageChat.Controls.Clear();
            }

            _container.MessageService.ConnectToMessageHub(username);
            initializeChatBox(username);
        }

        private async void updateMessageThread(object sender, NotifyCollectionChangedEventArgs e)
        {
            var user = _container.AccountManager.User;

            if (e.NewItems != null)
            {
                if (_chatBox == null)
                {
                    var mess = ((MessageDto)e.NewItems[0]);
                    var otherUsername = mess.SenderUsername != user.Username
                        ? mess.SenderUsername
                        : mess.RecipientUsername;
                    initializeChatBox(otherUsername);
                }
                foreach (MessageDto message in e.NewItems)
                {
                    var otherUsername = message.RecipientUsername == user.Username
                        ? message.SenderUsername
                        : message.RecipientUsername;

                    var otherUser = await _container.UsersManager.GetUserByUsername(otherUsername);

                    var chatModel = new TextChatModel
                    {
                        Body = message.Content,
                        Author = otherUser.KnownAs,
                        Read = message.DateRead != null,
                        Time = message.MessageSent,
                        Inbound = user.Username != message.SenderUsername
                    };

                    _chatBox.AddMessage(chatModel, message);
                }
            }

            if (e.OldItems != null)
            {
                foreach (MessageDto message in e.OldItems)
                {
                    _chatBox.RemoveMessage(message);
                }
            }
        }

        private async void initializeChatBox(string userName)
        {
            var sender = await _container.UsersManager.GetUserByUsername(userName);

            ChatboxInfo chatboxInfo = new ChatboxInfo();
            chatboxInfo.OtherUsername = userName;
            chatboxInfo.NamePlaceholder = sender.KnownAs;
            chatboxInfo.PhonePlaceholder = "";
            chatboxInfo.User = _container.AccountManager.User.KnownAs;

            _chatBox = new Chatbox(chatboxInfo, _container);
            _chatBox.Name = "chat_panel";
            _chatBox.Dock = DockStyle.Fill;
            panelMessageChat.Controls.Add(_chatBox);
        }

        private void MessagesForm_Closing(Object sender, FormClosingEventArgs e)
        {
            _connection.StopAsync();
        }

        private async void connectToInboxMessagesHub()
        {
            _connection = new HubConnectionBuilder()
            .WithUrl(new Uri(Constants.Api.HubUrl + Constants.Api.HubRoutePaths.InboxMessagesHub), opt =>
            {
                opt.AccessTokenProvider = () => Task.FromResult(_container.AccountManager.User.Token);
            })
            .WithAutomaticReconnect()
            .Build();

            _connection.On<List<MessageDto>>("ReceiveInboxMessages", (messages) =>
            {
                var tempList = messages;
                tempList.OrderByDescending(p => p.MessageSent);

                foreach (var message in tempList)
                {
                    MessagesList.Add(message);
                }
            });

            _connection.On<MessageDto>("NewInboxMessage", (message) =>
            {
                var otherUsername =
                    message.SenderUsername.ToLower() == _container.AccountManager.User.Username.ToLower()
                        ? message.RecipientUsername
                        : message.SenderUsername;

                if (MessagesList.Any(x => x.SenderUsername == otherUsername || x.RecipientUsername == otherUsername))
                {
                    var oldMessage = MessagesList.First(x =>
                        x.SenderUsername == otherUsername || x.RecipientUsername == otherUsername);

                    MessagesList.Remove(oldMessage);
                }

                MessagesList.Add(message);
            });

            try
            {
                await _connection.StartAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private async void updateView(object sender, NotifyCollectionChangedEventArgs e)
        {
            var user = _container.AccountManager.User;

            if (e.NewItems != null)
            {
                foreach (MessageDto message in e.NewItems)
                {
                    MessageInboxOutbox.Add(message);

                    var otherUsername = message.RecipientUsername == user.Username
                        ? message.SenderUsername
                        : message.RecipientUsername;

                    var otherUser = await _container.UsersManager.GetUserByUsername(otherUsername);

                    var bubbleItemName = "bubbleItem" + message.Id;

                    List<BubbleList> controlsToRemove = new List<BubbleList>();

                    foreach (BubbleList item in flowMessageList.Controls)
                    {
                        if (item.AccessibleName == otherUsername)
                        {
                            //MessageInboxOutbox.Remove(item.MessageDto);
                            //flowMessageList.Controls.Remove(item);
                            controlsToRemove.Add(item);
                        }
                    }

                    var bubbleList = new BubbleList(otherUsername, otherUser.KnownAs, message.Content, message.MessageSent, message);
                    bubbleList.Name = "bubbleItem" + message.Id;
                    bubbleList.DefaultBackColor = flowMessageList.BackColor;
                    bubbleList.Width = flowMessageList.Width;
                    bubbleList.MouseClick += BubbleList_MouseClick;
                    bubbleList.AccessibleName = otherUsername;

                    foreach (Control control in bubbleList.Controls)
                    {
                        control.MouseClick += BubbleList_MouseClick;
                        control.AccessibleName = otherUsername;
                    }

                    flowMessageList.Controls.Add(bubbleList);

                    foreach (var control in controlsToRemove)
                    {
                        flowMessageList.Controls.Remove(control);
                        MessageInboxOutbox.Remove(control.MessageDto);
                    }

                    SortControlsByOrderedMessageList(flowMessageList.Controls);
                }
            }

            if (e.OldItems != null)
            {
                foreach (MessageDto message in e.OldItems)
                {
                    MessageInboxOutbox.Remove(message);
                }
            }

            //flowMessageList.Controls.Clear();
            //if (isAnyMessage())
            //    await loadInboxMessagesList();

            panelMessageList.Visible = true;
            lblNoMessages.Visible = false;
            iconChatMessages.Visible = false;
        }

        private void SortControlsByOrderedMessageList(Control.ControlCollection controls)
        {
            var messages = MessageInboxOutbox.OrderByDescending(x => x.MessageSent).ToList();
            foreach (var message in messages.Select((value, i) => (value, i)))
            {
                var controlName = "bubbleItem" + message.value.Id;
                if (controls.ContainsKey(controlName))
                {
                    var control = controls.Find(controlName, true).First();
                    controls.SetChildIndex(control, message.i);
                }
            }
        }


        //private async Task<bool> loadInboxMessagesList(int pageNumber = 1, int pageSize = 10)
        //{
        //    foreach (var message in MessagesList)
        //    {
        //        var otherUsername = message.RecipientUsername == _container.AccountManager.User.Username
        //            ? message.SenderUsername
        //            : message.RecipientUsername;

        //        var otherUser = await _container.UsersManager.GetUserByUsername(otherUsername);

        //        var bubbleList = new BubbleList(otherUsername, otherUser.KnownAs, message.Content, message.MessageSent);
        //        bubbleList.DefaultBackColor = flowMessageList.BackColor;
        //        bubbleList.Width = flowMessageList.Width;
        //        bubbleList.MouseClick += BubbleList_MouseClick;
        //        bubbleList.AccessibleName = otherUsername;
        //        foreach (Control control in bubbleList.Controls)
        //        {
        //            control.MouseClick += BubbleList_MouseClick;
        //            control.AccessibleName = otherUsername;
        //        }

        //        var width = bubbleList.Width;

        //        flowMessageList.Controls.Add(bubbleList);
        //        flowMessageList.Controls.Add(new Divider(Color.LightGray, new Size(width, 1)));
        //    }
        //    return true;
        //}

        private void BubbleList_MouseClick(object sender, MouseEventArgs e)
        {
            var username = ((System.Windows.Forms.Control)sender).AccessibleName;
            if (_container.MessageService.IsConnectionToMessageHub())
            {
                _container.MessageService.DisconnectFromMessageHub();
                panelMessageChat.Controls.Clear();
            }

            _container.MessageService.ConnectToMessageHub(username);
            initializeChatBox(username);
        }

        private bool isAnyMessage()
        {
            return MessagesList.Any();
        }
    }
}
