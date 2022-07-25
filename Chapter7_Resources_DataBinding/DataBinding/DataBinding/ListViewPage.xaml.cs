namespace DataBinding;

public partial class ListViewPage : ContentPage
{
	public ListViewPage()
	{
		InitializeComponent();

		var viewModel = new PeopleModel();
		this.BindingContext = viewModel.People;
	}
}