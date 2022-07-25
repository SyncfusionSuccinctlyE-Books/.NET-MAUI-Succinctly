namespace Chapter6_Navigation;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void NavigateButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new SecondaryPage());
	}
}

