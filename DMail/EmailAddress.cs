using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DMail
{
    class EmailAddress
    {


        public string Address { get; private set; }
        public SmtpClient SmtpServer { get; private set; }

        public EmailAddress(string address, SmtpClient smtpServer )
        {
            this.Address = address;
            this.SmtpServer = smtpServer;
        }

    }
}
