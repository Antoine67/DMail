using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DMail
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class SenderSelector : Window
    {
        public SenderSelector()
        {
            InitializeComponent();

            //Configure a mail sender
            MailSender ms = new MailSender();

            //Specify smtp specifications
            SmtpClient smtpServer = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
            smtpServer.UseDefaultCredentials = true;
            smtpServer.Credentials = new System.Net.NetworkCredential("inutile0706@gmail.com", "");
            smtpServer.EnableSsl = true;
            
            smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;

            //Setup the sender email associated with corresponding smtp server
            ms.SenderEmail = new EmailAddress("inutile0706@gmail.com", smtpServer);

            //Finally send mail
            //ms.SendMail("test", "test", "antoine.mohr@viacesi.fr");

            LoadSenderEmailList();
            LoadRecipientEmailList();
        }

        private void LoadRecipientEmailList()
        {
            this.LB_Recipient_Email_Address.Items.Add("test");
            LB_Recipient_Email_Address.Items.SortDescriptions.Add(
                new System.ComponentModel.SortDescription("",
                System.ComponentModel.ListSortDirection.Ascending));
        }

        private void LoadSenderEmailList()
        {
            this.LB_Sender_Email_Address.Items.Add("test");
            this.LB_Sender_Email_Address.Items.Add("aaaa");
            this.LB_Sender_Email_Address.Items.Add("test");
            this.LB_Sender_Email_Address.Items.Add("aaaa");
            this.LB_Sender_Email_Address.Items.Add("test");
            this.LB_Sender_Email_Address.Items.Add("aaaa");
            this.LB_Sender_Email_Address.Items.Add("test");
            this.LB_Sender_Email_Address.Items.Add("aaaa");
            this.LB_Sender_Email_Address.Items.SortDescriptions.Add(
                new System.ComponentModel.SortDescription("",
                System.ComponentModel.ListSortDirection.Ascending));
        }
    }
}
