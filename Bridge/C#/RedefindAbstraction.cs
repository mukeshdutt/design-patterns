namespace Bridge
{
    public class SystemMessage : Message
    {
        public override void Send()
        {
            MessageSender.SendMessage(Subject, Body);
        }
    }

    public class UserMessage : Message
    {
        public string Comment { get; set; }
        public override void Send()
        {
            var message = $"{Body}, User Comment : {Comment}";
            MessageSender.SendMessage(Subject, message);
        }
    }
}