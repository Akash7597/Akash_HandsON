using System;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;



namespace Serialization.SRP
{
    public class UserRegistration
    {
        public void RegisterUser(string uname, string pwd)
        {
            Console.WriteLine($"User registered with {uname} and {pwd}");
        }
    }
    public class Logger
    {
        public void LogError(string content)
        {
            try
            {
                if (!EventLog.SourceExists("SRPDemo")) ;
                {
                    EventLog.CreateEventSource("SRPDemo", "SRPDemo");
                }
                EventLog.WriteEntry("Source", content, EventLogEntryType.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
        }
    }
    public class SendMail
    {
        public void Compose(string email, string subject, string content)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("akodiyaakash@gmail.com");
                message.To.Add(new MailAddress(email));
                message.Subject = subject;
                message.IsBodyHtml = true;
                message.Body = content;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("akodiyaakash@gmail.com", "abc123");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                Console.WriteLine($"Email sent to {email}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
        }
    }
    public class SRP
    {
        public static void Main(string[] args)
        {
            try
            {
                var user = new UserRegistration();
                user.RegisterUser("Akash", "Kumar");



                var email = new SendMail();
                email.Compose("akodiyaakash@gmail.com", "User Registered", "Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
        }
    }
}