using DatingApp.App;
using Local.DTOs.Messages;
using Local.Helpers;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local.Managers
{
    public interface IMessagesManager
    {
        Task<List<MessageDto>> GetMessagesForUser(string userName, int pageNumber = 1, int pageSize = 10, string container = "Inbox");
    }

    public class MessagesManager : IMessagesManager
    {
        private readonly IContainer _container;

        public MessagesManager(IContainer container)
        {
            _container = container;
        }

        public async Task<List<MessageDto>> GetMessagesForUser(string userName, int pageNumber = 1, int pageSize = 10, string container = "Inbox")
        {
            var param = new Dictionary<string, string>() { { "Username", userName },
                                                           { "PageNumber", pageNumber.ToString() },
                                                           { "PageSize", pageSize.ToString() },
                                                           { "Container", container }};

            var uri = QueryHelpers.AddQueryString(Constants.Api.DefaultRoutePaths.Messages, param);
            var jsonResult = await ApiHelper.Get(uri, _container.AccountManager.User.Token);

            var messages = JsonConvert.DeserializeObject<List<MessageDto>>(jsonResult);

            return messages;
        }

        

    }
}
