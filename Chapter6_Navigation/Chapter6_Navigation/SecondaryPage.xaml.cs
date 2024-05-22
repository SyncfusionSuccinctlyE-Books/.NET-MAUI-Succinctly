namespace Chapter6_Navigation;

public partial class SecondaryPage : ContentPage
{
	public SecondaryPage()
	{
		InitializeComponent();
	}

    private async void NavigateBackButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}