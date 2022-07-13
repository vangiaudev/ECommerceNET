using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceNET.MailMessenger
{
    public interface IEmailSender
    {
        void SendEmail(Message messenger);
    }
}
