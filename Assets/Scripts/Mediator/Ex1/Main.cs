using UnityEngine;

namespace Mediator.Ex1
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            AbstractChatroom chatroom = new Chatroom();

            Participant Yoko = new NonBeetle("Yoko");
            Participant Paul = new Beetle("Paul");
            Participant John = new Beetle("John");
            Participant Ringo = new Beetle("Ringo");
            Participant George = new Beetle("George");

            chatroom.Register(Paul);
            chatroom.Register(John);
            chatroom.Register(Yoko);
            chatroom.Register(Ringo);
            chatroom.Register(George);

            Yoko.Send(John.Name, "Hi John!");
            Paul.Send(Ringo.Name, "All you need is love");
            Ringo.Send(George.Name, "My sweet Lord");
            Paul.Send(John.Name, "Can't buy me love");
            John.Send(Yoko.Name, "My sweet love");
        }
    }
}
