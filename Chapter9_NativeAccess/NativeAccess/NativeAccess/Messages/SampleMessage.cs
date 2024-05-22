using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NativeAccess.Messages
{
    public class SampleMessage : ValueChangedMessage<bool>
    {
        public SampleMessage(bool value) : base(value)
        {
        }
    }
}
