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
        private Chatbox _chatBox;


        public MessagesForm(Local.IContainer container)
        {
            _container = container;
            MessagesList = new ObservableCollection<MessageDto>();
            MessagesList.CollectionChanged += updateView;
            InitializeComponent();
            connectToInboxMessagesHub();
            this.FormClosing += MessagesForm_Closing;
            _container.MessageService.MessageThread.CollectionChanged += updateMessageThread;
        }

        private async void updateMessageThread(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (MessageDto item in e.NewItems)
            {
                var messageSender = await _container.UsersManager.GetUserByUsername(item.SenderUsername);

                var chatModel = new TextChatModel
                {
                    Body = item.Content,
                    Author = messageSender.KnownAs,
                    Read = item.DateRead != null,
                    Time = item.MessageSent,
                    Inbound = _container.AccountManager.User.Username != item.SenderUsername
                };

                _chatBox.AddMessage(chatModel);
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
                var oldMessage = MessagesList.FirstOrDefault(p => p.SenderId == message.SenderId);
                MessagesList.Remove(oldMessage);
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
            flowMessageList.Controls.Clear();
            if (isAnyMessage())
                loadInboxMessagesList();

            panelMessageList.Visible = isAnyMessage();
            lblNoMessages.Visible = !isAnyMessage();
            iconChatMessages.Visible = !isAnyMessage();
        }

        private async void loadInboxMessagesList(int pageNumber = 1, int pageSize = 10)
        {
            foreach (var message in MessagesList)
            {
                var otherUsername = message.RecipientUsername == _container.AccountManager.User.Username
                    ? message.SenderUsername
                    : message.RecipientUsername;

                var otherUser = await _container.UsersManager.GetUserByUsername(otherUsername);

                var bubbleList = new BubbleList(otherUsername, otherUser.KnownAs, message.Content, message.MessageSent);
                bubbleList.DefaultBackColor = flowMessageList.BackColor;
                bubbleList.Width = flowMessageList.Width;
                bubbleList.MouseClick += BubbleList_MouseClick;
                bubbleList.AccessibleName = otherUsername;
                foreach (Control control in bubbleList.Controls)
                {
                    control.MouseClick += BubbleList_MouseClick;
                    control.AccessibleName = otherUsername;
                }

                var width = bubbleList.Width;

                flowMessageList.Controls.Add(bubbleList);
                flowMessageList.Controls.Add(new Divider(Color.LightGray, new Size(width, 1)));
            }
        }

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
