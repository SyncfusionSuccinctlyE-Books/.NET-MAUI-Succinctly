namespace DataBinding;

public partial class CollectionsPage : ContentPage
{
	public CollectionsPage()
	{
		InitializeComponent();

		var peopleCollection = new PeopleModel();
		BindingContext = peopleCollection;
	}

	private void PeopleList_SelectionChanged(object sender, 
        SelectionChangedEventArgs e)
	{
        // In case of single selection
        var selectedPerson = this.PeopleList.SelectedItem as Person;

        // In case of multi-selection:
        var singlePerson = e.CurrentSelection.FirstOrDefault()
            as Person;

        var selectedObjects = e.CurrentSelection.Cast<Person>();
        foreach (var person in selectedObjects)
        {
            // Handle your object properties here...
        }
    }
}