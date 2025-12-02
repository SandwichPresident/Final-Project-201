namespace FinalProject201
{
    public partial class LoginPage : ContentPage
    {

        public LoginPage()
        {
            InitializeComponent();
        }

        private async void LoginClicked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//MenuPage");
        }
    }
}
