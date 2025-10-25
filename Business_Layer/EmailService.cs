using System;
using System.Net;
using System.Net.Mail;
using PlugAndPlay.Common;

namespace PlugAndPlay.Business
{
    public class EmailService
    {
        public bool SendMail(MessageEmail message)
        {
            try
            {
                var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
                {
                    Credentials = new NetworkCredential("b26c248edfcbfd", "b05bf7c8d280cc"),
                    EnableSsl = true
                };

                var mail = new MailMessage();
                mail.From = new MailAddress(message.From);
                mail.To.Add(message.To);
                mail.Subject = message.Subject;
                mail.Body = message.Body;

                client.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
                return false;
            }
        }
    }
}
