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

namespace sdf2
{
    public partial class Mail : Form
    {
        MailMessage mail = new MailMessage();
        static OpenPop.Pop3.Pop3Client client = new OpenPop.Pop3.Pop3Client();
        static StringBuilder builder = new StringBuilder();

        public Mail()
        {
            InitializeComponent();
        }

        private void sendMail_Click(object sender, EventArgs e)
        {
            SmtpClient SmtpServer = new SmtpClient();
            SmtpServer.Credentials =
                new System.Net.NetworkCredential("its2019mezun@gmail.com", "mezun2019");
            SmtpServer.Port = 587;
            SmtpServer.Host = "smtp.gmail.com";
            SmtpServer.EnableSsl = true;
            mail.To.Add(mailTo.Text);
            mail.From = new MailAddress("its2019mezun@gmail.com");
            mail.Subject = subject.Text;
            mail.Body = message.Text;
            SmtpServer.Send(mail);

            MessageBox.Show("Your message is sent!");

            message.Clear();
            subject.Clear();
            mailTo.Clear();

        }
    }
}
