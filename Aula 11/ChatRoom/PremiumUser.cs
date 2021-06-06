using System;

namespace ChatRoom
{
    class PremiumUser : User
    {
        public PremiumUser(string name, IChatRoomMediator mediator) :base(name, mediator)
        {
        }
        
        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"[User Type: Premium] {Name}: {message}");
        }
    }
}