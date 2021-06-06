using System;
using System.Text;

namespace ChatRoom
{
    interface IChatRoomMediator
    {
        void Register(IUser user);
        void SendMessage(IUser sender, string message);
    }
}
