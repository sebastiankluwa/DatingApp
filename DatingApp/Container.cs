using DatingApp.App;
using Local.Managers;
using Local.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local
{
    public interface IContainer
    {
        IAccountManager AccountManager { get; set; }
        IMessageService MessageService { get; set; }
        IMessagesManager MessagesManager { get; set; }
        IUsersManager UsersManager { get; set; }
    }

    public class Container : IContainer
    {
        public IAccountManager AccountManager { get; set; }
        public IMessagesManager MessagesManager { get; set; }
        public IMessageService MessageService { get; set; }
        public IUsersManager UsersManager { get; set; }
    }
}
