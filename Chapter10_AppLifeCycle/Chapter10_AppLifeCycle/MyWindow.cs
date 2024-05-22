namespace Chapter10_AppLifeCycle
{
    public class MyWindow : Window
    {
        public MyWindow() : base()
        {

        }

        public MyWindow(Page page) : base(page)
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
