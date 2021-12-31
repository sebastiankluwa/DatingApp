using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local.DTOs.Messages
{
    public class MessageParams
    {
        public string Username { get; set; }
        public string Container { get; set; } = "Inbox";

        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
