namespace FinalProject201
{
    public partial class MainPage : ContentPage
    {
        Dictionary<string, string> userLogins = new Dictionary<string, string>();

        public MainPage()
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
            if (Username.Text == null || Password.Text == null)
            {
                //"please type username and password!"
                await DisplayAlert("Login Error", "Please type your username and password to continue!", "OK");
            }
            else
            {
                string username = Username.Text;
                string password = Password.Text;

                if (!userLogins.ContainsKey(username))
                {
                    //adds login info to text file
                    StreamWriter writer = new StreamWriter("login.txt", true);
                    writer.WriteLine($"{username}, {password}");
                    writer.Close();
                }
                else if (password != userLogins[username])
                {
                    //incorrect password
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