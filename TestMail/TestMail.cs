using System;
using PlugAndPlay.Business;
using PlugAndPlay.Common;

class TestMail
{
    static void Main()
    {
        var email = new EmailMessage
        {
            To = "yourmail@gmail.com",
            Subject = "Testing Mailtrap API",
            Body = "<h1>Email Successfully Sent! ✅</h1>"
        };

        var service = new serviceMail();
        var result = service.SendEmail(email);

        Console.WriteLine(result);
        Console.ReadLine(); // para hindi magsara agad
    }
}
