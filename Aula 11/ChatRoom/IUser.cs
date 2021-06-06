using System;

namespace ChatRoom
{
    public interface IUser
    {
        void SendMessage(string message);
        void ReceiveMessage(string message);
    }

    abstract class User : IUser
    {
        protected User(string name, IChatRoomMediator mediator)
        {
            Name = name;
            Mediator = mediator;
        }

        protected string Name { get; }
        protected IChatRoomMediator Mediator { get; }

        public void SendMessage(string message)
        {
            Mediator.SendMessage(this, message);
        }

        public virtual void ReceiveMessage(string message)
        {
            Console.WriteLine($"{Name}: {message}");
        }
    }
}