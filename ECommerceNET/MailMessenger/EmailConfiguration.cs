using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceNET.MailMessenger
{
    public class EmailConfiguration
    {
        public string  From { get; set; }
        public string Smtpserver { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
