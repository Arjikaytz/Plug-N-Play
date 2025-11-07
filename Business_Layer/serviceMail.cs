using System;
using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Options;
using PlugAndPlay.Common;

namespace PlugAndPlay.Business
{
    public class serviceMail
    {
        private readonly MailSettings _mailSettings;

        public serviceMail(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }

        // Constructor overload for quick tests (optional)
        public serviceMail(MailSettings settings)
        {
            _mailSettings = settings;
        }

        public string SendEmail(EmailMessage message)
        {
            try
            {
                var mail = new MailMessage();
                mail.From = new MailAddress(_mailSettings.From, _mailSettings.FromName);
                mail.To.Add(message.To);
                mail.Subject = message.Subject;
                mail.Body = message.Body;
                mail.IsBodyHtml = true;

                using (var client = new SmtpClient())
                {
                    client.Host = _mailSettings.Host;
                    client.Port = _mailSettings.Port;
                    client.EnableSsl = _mailSettings.UseSSL; // Enable for STARTTLS or implicit SSL
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(_mailSettings.Username, _mailSettings.Password);

                    // Timeout (ms) - optional
                    client.Timeout = 20000;

                    client.Send(mail);
                }

                return "Email sent successfully.";
            }
            catch (SmtpException smtpEx)
            {
                // More specific SMTP errors
                return $"SMTP Error: {smtpEx.StatusCode} - {smtpEx.Message}";
            }
            catch (Exception ex)
            {
                return $"Error sending email: {ex.Message}";
            }
        }
    }
}
