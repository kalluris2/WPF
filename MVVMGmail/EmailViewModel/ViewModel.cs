using LoginCrediantials;
using System;
using System.Net;
using System.Net.Mail;
using System.Windows;

namespace EmailViewModel
{
    public class ViewModel
    {
       
            public void Email(Inputs input)
            {
                try
                {
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(input.Sender);
                    message.To.Add(input.Receiver);
                    message.CC.Add(input.CC);
                    message.Body = input.Message;
                    client.UseDefaultCredentials = false;
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential(input.Sender, input.Password);
                    client.Send(message);

                    MessageBox.Show("mail sent");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
    }
        
       

    
        

       

    
}
