using System;

namespace Bridge
{
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            System.Console.WriteLine($"Email : {subject} {body}");
        }
    }
    
    public class WebServiceSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            System.Console.WriteLine($"Web Service : {subject} {body}");
        }
    }
    
    public class MSMQSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            System.Console.WriteLine($"MSMQ : {subject} {body}");
        }
    }
}