namespace Chapter8_Brushes_Shapes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Shapes.PolylinePage();
        }
    }
}
