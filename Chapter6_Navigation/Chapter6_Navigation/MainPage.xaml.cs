namespace Chapter6_Navigation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void NavigateButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondaryPage());
        }
    }
}
