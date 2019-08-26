using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;
using MailKit.Net.Smtp;

namespace mailerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string FromAddress = fromAddress.Text;
            string Password = password.Text;
            string ToAddress = toAddress.Text;
            string Title = title.Text;
            string Contain = contain.Text;
            SendMailAsync(FromAddress, Password, Contain, Title, ToAddress);
        }
        static async void SendMailAsync(string FromAddress, string Password, string Contain, string Title, string ToAddress)
        {
            var message = new MimeKit.MimeMessage();
            message.From.Add(new MimeKit.MailboxAddress(FromAddress, FromAddress));
            message.To.Add(new MimeKit.MailboxAddress(ToAddress, ToAddress));
            message.Subject = Title;
            var textPart = new MimeKit.TextPart(MimeKit.Text.TextFormat.Plain);
            textPart.Text = @Contain;
            message.Body = textPart;
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                try
                {
                    await client.ConnectAsync("smtp.gmail.com", 587);
                    await client.AuthenticateAsync(FromAddress, Password);
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);

                }
                catch(Exception ex)
                {
                    Form2 form2 = new Form2();
                    form2.text(ex.ToString());

                    form2.ShowDialog();
                }
            }
                
        }

    }

    

}
