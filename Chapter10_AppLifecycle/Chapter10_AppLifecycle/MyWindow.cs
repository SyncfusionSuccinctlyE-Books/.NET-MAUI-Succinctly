using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10_AppLifecycle
{
    public class MyWindow: Window
    {
        public MyWindow(): base()
        {

        }

        public MyWindow(Page page): base(page)
        {

        }

        protected override void OnCreated()
        {
            base.OnCreated();
        }

        protected override void OnActivated()
        {
            base.OnActivated();
        }
    }
}
