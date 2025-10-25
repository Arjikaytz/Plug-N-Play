using System;
using System.Net;
using System.Net.Mail;
using PlugAndPlay.Common;

namespace PlugAndPlay.Business
{
    public class serviceMail
    {
        public string SendEmail(EmailMessage message)
        {
            try
            {
                var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
                {
                    Credentials = new NetworkCredential("b26c248edfcbfd", "b05bf7c8d280cc"),
                    EnableSsl = true
                };

                client.Send(message.From, message.To, message.Subject, message.Body);
                return "Email sent successfully.";
            }
            catch (Exception ex)
            {
                return "Failed to send email: " + ex.Message;
            }
        }
    }
}
    