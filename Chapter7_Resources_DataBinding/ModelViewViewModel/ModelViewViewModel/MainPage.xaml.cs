using ModelViewViewModel.ViewModel;

namespace ModelViewViewModel
{
    public partial class MainPage : ContentPage
    {
        private PersonViewModel ViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();

            this.ViewModel = new PersonViewModel();
            this.BindingContext = this.ViewModel;

        }
    }

}
