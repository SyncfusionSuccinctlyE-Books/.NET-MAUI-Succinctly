namespace Chapter6_Navigation.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();

        var data = new ProductCollection();
        BindingContext = data;
    }
}