using CommunityToolkit.Mvvm.Messaging;
using NativeAccess.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NativeAccess.ViewModels
{
    public class DemoViewModel
    {
        public Command DoSomethingCommand
        {
            get
            {
                return new Command(() =>
                {
                    // Do something here
                    // and send a message when done
                    bool result = false;
                    if(DateTime.Now.TimeOfDay > TimeSpan.FromHours(7))
                        result=true;
                    
                    WeakReferenceMessenger.Default.Send(new SampleMessage(result));
                });
            }
        }
    }
}
