using DatingApp.App;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local.Services
{
    public interface IMessageService
    {
        void ConnectToMessageHub();
    }

    public class MessageService : IMessageService
    {
        private readonly IContainer _container;
        private HubConnection _messageHubConnection;

        public MessageService(IContainer container)
        {
            _container = container;
        }

        public async void ConnectToMessageHub()
        {
            _messageHubConnection = new HubConnectionBuilder()
            .WithUrl(new Uri(Constants.Api.HubUrl + Constants.Api.HubRoutePaths.InboxMessagesHub), opt =>
            {
                opt.AccessTokenProvider = () => Task.FromResult(_container.AccountManager.User.Token);
            })
            .WithAutomaticReconnect()
            .Build();

            //_messageHubConnection.On<List<MessageDto>>("ReceiveInboxMessages", (messages) =>
            //{
            //    this.messages = messages;
            //    this.messages.OrderByDescending(p => p.MessageSent);

            //    updateView();
            //});

            //_messageHubConnection.On<MessageDto>("NewInboxMessage", (message) =>
            //{
            //    var oldMessage = this.messages.FirstOrDefault(p => p.SenderId == message.SenderId);
            //    this.messages.Remove(oldMessage);
            //    this.messages.Add(message);
            //    this.messages.Sort((a, b) => b.MessageSent.CompareTo(a.MessageSent));

            //    updateView();
            //});

            try
            {
                await _messageHubConnection.StartAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
