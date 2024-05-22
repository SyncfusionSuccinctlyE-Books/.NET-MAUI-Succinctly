using Chapter10_AppLifeCycle.Messages;
using Chapter10_AppLifeCycle.ViewModels;
using CommunityToolkit.Mvvm.Messaging;

namespace Chapter10_AppLifeCycle;

public partial class BroadcastMessagePage : ContentPage
{
    private BroadcastMessageViewModel ViewModel { get; set; }
    public BroadcastMessagePage()
    {
        InitializeComponent();
        ViewModel = new BroadcastMessageViewModel();
        BindingContext = ViewModel;
        WeakReferenceMessenger.Default.Register<ActionExecutedMessage>
                     (this, ButtonTapped);
    }

    private async void ButtonTapped(object recipient, ActionExecutedMessage message)
    {
        await DisplayAlert("Info", "You clicked the button!", "OK");
    }

    protected override void OnDisappearing()
    {
        WeakReferenceMessenger.Default.Unregister<ActionExecutedMessage>
                      (this);
        base.OnDisappearing();
    }
}