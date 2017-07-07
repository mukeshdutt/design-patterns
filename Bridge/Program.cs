using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bridge and their implementation
            IMessageSender email = new EmailSender();
            IMessageSender msmq = new MSMQSender();
            IMessageSender web = new WebServiceSender();

            Message message = new SystemMessage();
            message.Subject = "Test Message";
            message.Body = "Hi, This is test message";
            
            message.MessageSender = email;
            message.Send();
            
            message.MessageSender = msmq;
            message.Send();
            
            message.MessageSender = web;
            message.Send();

            // User Message
            UserMessage userMessage = new UserMessage();
            userMessage.Subject = "User Message";
            userMessage.Body = "Hi, this is user test message";
            userMessage.Comment = "I hope you enjoying";
            userMessage.MessageSender = email;
            userMessage.Send();
        }
    }
}
