using API.Extensions;
using API.Interfaces;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.SignalR
{
    public class MessageInboxHub : Hub
    {
        private readonly IUnitOfWork _unitOfWork;

        public MessageInboxHub(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public override async Task OnConnectedAsync()
        {
            var httpContext = Context.GetHttpContext();
            var groupName = Context.User.GetUsername();
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
            //await Clients.Group(groupName).SendAsync("UpdatedGroup", group);
            var messages = await _unitOfWork.MessageRepository.GetInboxMessagesForUser(Context.User.GetUsername());

            await Clients.Caller.SendAsync("ReceiveInboxMessages", messages);
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await base.OnDisconnectedAsync(exception);
        }
    }
}
