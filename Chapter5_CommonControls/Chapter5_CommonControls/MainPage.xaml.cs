namespace Chapter5_CommonControls;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}


	//private void Button1_Clicked(object sender, EventArgs e)
	//{

	//}

	private void Entry1_Completed(object sender, EventArgs e)
	{
	}

	private void TimePicker1_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
	{
		//if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
		//{
		//	TimeSpan selectedTime = TimePicker1.Time;
		//}

	}

	private void Switch1_Toggled(object sender, ToggledEventArgs e)
	{
		bool isToggled = e.Value;
	}

	private void Slider1_ValueChanged(object sender, ValueChangedEventArgs e)
	{

	}

	//private void Stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
	//{
	//	StepperValue.Text = e.NewValue.ToString();
	//}

	private void SearchBar1_SearchButtonPressed(object sender, EventArgs e)
	{
		
	}

	private void CheckBox1_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		bool selectedValue = e.Value;
	}

	private async void ActionSheetButton_Clicked(object sender, EventArgs e)
	{
   //     bool result =
			//await DisplayAlert("Title", "Do you wish to continue?", "OK", "Cancel");
	
        //string result1 = await DisplayActionSheet("Select the destination", "Cancel", "Delete file", "Microsoft OneDrive", "Google Drive", "Apple iCloud", "Local device");
        string promptResult = await DisplayPromptAsync("Welcome question", "Where did you hear about us from?");
    }

	private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		
	}
}

