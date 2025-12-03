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
            if (LoginPass.Text != null && LoginUser.Text != null)
            {                
                await Shell.Current.GoToAsync("//MenuPage");
            } else
            {
                //"please type username and password!"
                await DisplayAlert("Warning", "Please type your username and password to continue!", "OK");

            }
        }


    }
}
