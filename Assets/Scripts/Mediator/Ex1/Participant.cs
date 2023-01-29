namespace Mediator.Ex1
{
    internal class Participant
    {
        public Participant(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public AbstractChatroom Chatroom { get; set; }
        protected string ModifyMessage { get; private set; }

        public void Send(string to, string message)
        {
            Chatroom.Send(Name, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            ModifyMessage = $"{from} to {Name} : '{message}'";
        }
    }
}