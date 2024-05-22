using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Chapter10_AppLifeCycle.Messages
{
    public class ActionExecutedMessage : ValueChangedMessage<bool>
    {
        public ActionExecutedMessage(bool value) : base(value)
        {

        }
    }

}
