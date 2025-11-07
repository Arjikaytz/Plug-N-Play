using System;
using PlugAndPlay.Business;
using PlugAndPlay.Common;

class TestMail
{
    static void Main()
    {
        var settings = new MailSettings
        {
            Host = "sandbox.smtp.mailtrap.io",
            Port = 587,
            Username = "b26c248edfcbfd",
            Password = "YOUR_MAILTRAP_PASSWORD",
            From = "noreply@yourdomain.com",
            FromName = "Console Test",
            UseSSL = true
        };

        var service = new serviceMail(settings);

        var email = new EmailMessage
        {
            To = "yourmail@gmail.com",
            Subject = "Testing Mailtrap API",
            Body = "<h1>Email Successfully Sent! ✅</h1>"
        };

        var result = service.SendEmail(email);

        Console.WriteLine(result);
        Console.ReadLine();
    }
}
