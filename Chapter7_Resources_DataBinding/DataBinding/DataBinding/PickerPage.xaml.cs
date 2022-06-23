using System.Collections.ObjectModel;

namespace DataBinding;

public partial class PickerPage : ContentPage
{
	public PickerPage()
	{
		InitializeComponent();

        var apple = new Fruit { Name = "Apple", Color = "Green" };
        var strawberry = new Fruit { Name = "Strawberry", Color = "Red" };
        var orange = new Fruit { Name = "Orange", Color = "Orange" };

        var fruitList = new ObservableCollection<Fruit>()
            { apple, strawberry, orange };
        this.FruitPicker.ItemsSource = fruitList;

    }

    private async void FruitPicker_SelectedIndexChanged(object sender, EventArgs e)
	{
        var currentFruit = this.FruitPicker.SelectedItem as Fruit;
        if (currentFruit != null)
            await DisplayAlert("Selection",
            $"You selected {currentFruit.Name}", "OK");

    }
}