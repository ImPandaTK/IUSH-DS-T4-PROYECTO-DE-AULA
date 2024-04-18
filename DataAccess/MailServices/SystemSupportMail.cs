using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MailServices
{
    internal class SystemSupportMail:MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = "soportequackpay@gmail.com";
            password = "mama12347";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
