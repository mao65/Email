using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace Email
{
    public partial class Form1 : Form
    {
        static Form1 f;

        public Form1()
        {
            InitializeComponent();
            f = this;
        }

        private void wyslijBtn_Click(object sender, EventArgs e)
        {
            var mess = new MailMessage(emailTxt.Text, odbiorcaTxt.Text);
            mess.Subject = tematTxt.Text;
            mess.Body = msgTxt.Text;

            using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587))
            {
                mailer.Credentials = new NetworkCredential(emailTxt.Text, passTxt.Text);
                mailer.EnableSsl = true;
                mailer.Send(mess);
            }

            odbiorcaTxt.Text = null;
            tematTxt.Text = null;
            msgTxt.Text = null;
        }

        
    }
}
