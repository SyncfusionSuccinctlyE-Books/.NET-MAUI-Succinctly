using CommunityToolkit.Mvvm.Messaging;
using NativeAccess.Messages;
using NativeAccess.ViewModels;

namespace NativeAccess
{
    public partial class MainPage : ContentPage
    {
        private DemoViewModel ViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            WeakReferenceMessenger.Default.Register<SampleMessage>(this, ShowAlert);
            ViewModel = new DemoViewModel();
            BindingContext = ViewModel;

            Connectivity.Current.ConnectivityChanged += Current_ConnectivityChanged;

            // Label1 is a Label view in the UI
            if (DeviceInfo.Current.Platform == DevicePlatform.Android)
                Label1.Text = "I'm running on Android";
            else if (DeviceInfo.Current.Platform == DevicePlatform.iOS)
                Label1.Text = "I'm running on iOS";
            else if (DeviceInfo.Current.Platform == DevicePlatform.MacCatalyst)
                Label1.Text = "I'm running on Mac Catalyst";
            else if (DeviceInfo.Current.Platform == DevicePlatform.Tizen)
                Label1.Text = "I'm running on Tizen";
            else if (DeviceInfo.Current.Platform == DevicePlatform.WinUI)
                Label1.Text = "I'm running on WinUI";

            if (DeviceInfo.Current.Idiom == DeviceIdiom.Tablet)
                Label1.Text = "I'm running on a tablet";
            if (DeviceInfo.Current.Idiom == DeviceIdiom.Desktop)
                Label1.Text = "I'm running on a desktop computer";
            if (DeviceInfo.Current.Idiom == DeviceIdiom.Watch)
                Label1.Text = "I'm running on a wearable device";
            if (DeviceInfo.Current.Idiom == DeviceIdiom.Phone)
                Label1.Text = "I'm running on a phone";
            if (DeviceInfo.Current.Idiom == DeviceIdiom.TV)
                Label1.Text = "I'm running on a tv";
            if (DeviceInfo.Current.Idiom == DeviceIdiom.Unknown)
                Label1.Text = "Unknown device";

            if (DeviceInfo.Current.DeviceType == DeviceType.Virtual)
                Label1.Text = "I'm on a simulator";

            //UI Localization direction
            this.FlowDirection = AppInfo.RequestedLayoutDirection.ToFlowDirection();
        }

        private async void ShowAlert(object recipient, SampleMessage message)
        {
            switch(message.Value)
            {
                case true:
                    await DisplayAlert("Info", "Something was done.", "OK");
                    break;
                default:
                    await DisplayAlert("Info", "Something was done.", "OK");
                    break;

            }
        }

        private async void Current_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            if (e.NetworkAccess != NetworkAccess.Internet)
            {
                await DisplayAlert("Warning", "Limited internet connection", "OK");
                // Do additional work to limit network access...
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            DeviceOrientationService deviceOrientationService =
                new DeviceOrientationService();
            DeviceOrientation orientation =
                deviceOrientationService.GetOrientation();
        }

        private async void CheckConnection()
        {
            if (Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
            {
                // Internet connection available
                await Browser.OpenAsync("https://www.microsoft.com", BrowserLaunchMode.SystemPreferred);

            }

            IEnumerable<ConnectionProfile> profiles = Connectivity.Current.ConnectionProfiles;
            if (profiles.Contains(ConnectionProfile.WiFi))
            {
                // WiFi connection
            }

        }

        public async Task SendSms(string messageText, string[] recipients)
        {
            var message = new SmsMessage(messageText, recipients);
            await Sms.Default.ComposeAsync(message);
        }

    }

}
