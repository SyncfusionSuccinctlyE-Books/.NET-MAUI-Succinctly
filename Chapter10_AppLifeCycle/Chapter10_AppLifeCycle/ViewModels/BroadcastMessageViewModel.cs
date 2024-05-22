using Chapter10_AppLifeCycle.Messages;
using CommunityToolkit.Mvvm.Messaging;

namespace Chapter10_AppLifeCycle.ViewModels
{
    public class BroadcastMessageViewModel
    {
        public Command ActionCommand
        {
            get
            {
                return new Command(() =>
                {
                    WeakReferenceMessenger.
                        Default.Send(new ActionExecutedMessage(true));
                });
            }
        }
    }

}
