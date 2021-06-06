using System;

namespace ChatRoom
{
    class BasicUser : User
    {
        public BasicUser(string name, IChatRoomMediator mediator) : base(name, mediator)
        {
        }
        
        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"[User Type: Basic] {Name}: {message}");
        }
    }
}