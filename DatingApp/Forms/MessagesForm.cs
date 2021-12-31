using DatingApp.App.Messages;
using DatingApp.App.Utils;
using Local;
using Local.DTOs.Messages;
using Local.Managers;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
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


        public MessagesForm(Local.IContainer container)
        {
            _container = container;

            InitializeComponent();
            connectToInboxMessagesHub();
            this.FormClosing += MessagesForm_Closing;
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
                this.messages = messages;
                this.messages.OrderByDescending(p => p.MessageSent);

                updateView();
            });

            _connection.On<MessageDto>("NewInboxMessage", (message) =>
            {
                var oldMessage = this.messages.FirstOrDefault(p => p.SenderId == message.SenderId);
                this.messages.Remove(oldMessage);
                this.messages.Add(message);
                this.messages.Sort((a, b) => b.MessageSent.CompareTo(a.MessageSent));

                updateView();
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

        private async void updateView()
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
            foreach (var message in this.messages)
            {
                var bubbleList = new BubbleList(message.SenderUsername, message.Content, message.MessageSent);
                bubbleList.DefaultBackColor = flowMessageList.BackColor;
                bubbleList.Width = flowMessageList.Width;
                var width = bubbleList.Width;

                flowMessageList.Controls.Add(bubbleList);
                flowMessageList.Controls.Add(new Divider(Color.LightGray, new Size(width, 1)));
            }
        }

        private bool isAnyMessage()
        {
            return this.messages.Any();
        }
    }
}
