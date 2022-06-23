namespace DataBinding;

public partial class SingleObjectPage : ContentPage
{
	public SingleObjectPage()
	{
		InitializeComponent();
        Person person = new Person();
        this.BindingContext = person;

    }
}