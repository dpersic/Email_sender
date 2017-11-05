using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMailSender
{
    public partial class MailSender : Form
    {
        public MailSender()
        {
            InitializeComponent();
        }
        public string sSmtpClient = "smtp.office365.com";
        public string sAddressFrom = "racunarac@vsmti.hr";
        public string sPassword = "Racunarstvo123";
        public int nPort = 587;
        public string sRecipient;
        public string sMessageTitle;
        public string sMessageBody;

        public void SendMail(string sRecipient, string sMessageTitle, string sMessageBody)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient(sSmtpClient);

            mail.From = new MailAddress(sAddressFrom);
            mail.To.Add(sRecipient);
            mail.Subject = sMessageTitle;
            mail.Body = sMessageBody;

            SmtpServer.Port = nPort;
            SmtpServer.Credentials = new System.Net.NetworkCredential(sAddressFrom, sPassword);
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }

        private void inptRecipient_TextChanged(object sender, EventArgs e)
        {
            sRecipient = Convert.ToString(inptRecipient.Text);
        }

        private void inptMessageTitle_TextChanged(object sender, EventArgs e)
        {
            sMessageTitle = Convert.ToString(inptMessageTitle.Text);
        }

        private void inptMessageBody_TextChanged(object sender, EventArgs e)
        {
            sMessageBody = Convert.ToString(inptMessageBody.Text);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMail(sRecipient, sMessageTitle, sMessageBody);
        }
    }
}
