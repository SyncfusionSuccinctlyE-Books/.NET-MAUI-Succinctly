namespace DataBinding;

public partial class CarouselViewPage : ContentPage
{
	public CarouselViewPage()
	{
		InitializeComponent();
        var peopleCollection = new PeopleModel();
        BindingContext = peopleCollection;
    }

    private void PeopleList_PositionChanged(object sender, PositionChangedEventArgs e)
    {

    }

    private void PeopleList_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    {

    }
}