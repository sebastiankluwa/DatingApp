using DatingApp.App;
using Local.DTOs;
using Local.DTOs.Messages;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local.Services
{
    public interface IMessageService
    {
        void ConnectToMessageHub(string otherUsername);
        void DisconnectFromMessageHub();
        ObservableCollection<MessageDto> MessageThread { get; set; }
        public List<MessageDto> Messages { get; set; }

        bool IsConnectionToMessageHub();
        void SendMessage(string recipientUsername, string content);
    }

    public class MessageService : IMessageService
    {
        public ObservableCollection<MessageDto> MessageThread { get; set; }
        public List<MessageDto> Messages { get; set; }
        private readonly IContainer _container;
        private HubConnection _messageHubConnection;

        public MessageService(IContainer container)
        {
            _container = container;
            MessageThread = new ObservableCollection<MessageDto>();
            Messages = new List<MessageDto>();
        }

        public async void ConnectToMessageHub(string otherUsername)
        {
            var url = new Uri(Constants.Api.HubUrl
                              + Constants.Api.HubRoutePaths.MessageHub
                              + "?user=" + otherUsername);

            _messageHubConnection = new HubConnectionBuilder()
                .WithUrl(url,
                    opt => { opt.AccessTokenProvider = () => Task.FromResult(_container.AccountManager.User.Token); })
                .WithAutomaticReconnect()
                .Build();

            _messageHubConnection.On<IEnumerable<MessageDto>>("ReceiveMessageThread", (messages) =>
            {
                Messages.AddRange(messages);

                foreach (var message in messages)
                {
                    MessageThread.Add(message);
                }
            });

            _messageHubConnection.On<MessageDto>("NewMessage", (message) =>
            {
                MessageThread.Add(message);
            });


            try
            {
                await _messageHubConnection.StartAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async void SendMessage(string recipientUsername, string content)
        {
            var createMessageDto = new CreateMessageDto
            {
                RecipientUsername = recipientUsername,
                Content = content
            };

            await _messageHubConnection.InvokeAsync("SendMessage", createMessageDto);
        }

        public async void DisconnectFromMessageHub()
        {
            await _messageHubConnection.StopAsync();
        }

        public bool IsConnectionToMessageHub()
        {
            return _messageHubConnection != null;
        }
    }
}