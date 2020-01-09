using System;
using System.Net.Mail;
using System.Windows;

namespace DMail
{
    class MailSender
    {
        private EmailAddress _senderEmail;

        public EmailAddress SenderEmail { get => _senderEmail; set => _senderEmail = value; }

        public bool SendMail(string body, string subject, string recipient)
        {
            try
            {
                MailMessage mail = new MailMessage();

                mail.From = new MailAddress(_senderEmail.Address);
                mail.To.Add(recipient);
                mail.Subject = subject;
                mail.Body = body;

                _senderEmail.SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return true;
        }

  

    }
}
