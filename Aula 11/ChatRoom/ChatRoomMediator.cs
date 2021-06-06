using System.Collections.Generic;

namespace ChatRoom
{
    class ChatRoomMediator : IChatRoomMediator
    {
        private readonly List<IUser> _participants = new List<IUser>();
        public void Register(IUser user)
        {
            if( _participants.Contains(user) ) return;
            _participants.Add(user);
        }
        public void SendMessage(IUser sender, string message)
        {
            foreach (var participant in _participants)
            {
                if (participant != sender)
                {
                    participant.ReceiveMessage(message);
                }
            }
        }
    }
}