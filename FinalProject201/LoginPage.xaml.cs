namespace FinalProject201
{
    public partial class LoginPage : ContentPage
    {
        Dictionary<string, string> userLogins = new Dictionary<string, string>();

        public LoginPage()
        {
            InitializeComponent();

            StreamReader reader = new StreamReader("login.txt");
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(", ");
                userLogins.Add(line[0], line[1]);
            }
            reader.Close();
        }

        private async void LoginClicked(object? sender, EventArgs e)
        {
            if (LoginPass.Text == null || LoginUser.Text == null)
            {
                //"please type username and password!"
                await DisplayAlert("Login Error", "Please type your username and password to continue!", "OK");
            }
            else
            {
                string username = LoginUser.Text;
                string password = LoginPass.Text;

                if (!userLogins.ContainsKey(username))
                {
                    await DisplayAlert("Login Error", "The username does not exist. Please create an account.", "OK");
                }
                else if (password != userLogins[username])
                {
                    await DisplayAlert("Login Error", "Incorrect password", "Try Again");
                }
                else
                {
                    await Shell.Current.GoToAsync("//MenuPage");
                } 
            }
        }
    }
}
