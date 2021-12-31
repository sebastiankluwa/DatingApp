using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local
{
    public static class Constants
    {
        public static class Api
        {
            public const string Url = "https://localhost:44363/api";
            public const string HubUrl = "https://localhost:44363/hubs";

            public static class DefaultRoutePaths
            {
                public const string Login = "/account/login";
                public const string Register = "/account/register";
                public const string Messages = "/messages";
            }

            public static class HubRoutePaths
            {
                public const string InboxMessagesHub = "/messageinbox";
                public const string PresenceHub = "/presence"; 
                public const string MessageHub = "/message";
            }
        }
    }
}
