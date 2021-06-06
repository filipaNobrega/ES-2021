using System;

namespace ChatRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatRoomMediator = new ChatRoomMediator();

            var participant1 = new BasicUser("John", chatRoomMediator);
            var participant2 = new BasicUser("Jess", chatRoomMediator);
            var participant3 = new BasicUser("Tom", chatRoomMediator);
            var participant4 = new PremiumUser("Sarah", chatRoomMediator);

            chatRoomMediator.Register(participant1);
            chatRoomMediator.Register(participant2);
            chatRoomMediator.Register(participant3);
            chatRoomMediator.Register(participant4);

            chatRoomMediator.SendMessage(participant3, "Hi everyone!");
        }
    }
}
