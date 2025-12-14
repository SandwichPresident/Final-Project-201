namespace FinalProject201
{ 

     // Main login page for the application.
    // Handles user authentication and account creation.
     
    public partial class MainPage : ContentPage
    {

    // Dictionary used to store usernames and passwords
        // Demonstrates use of a data structure for quick lookup
        
        Dictionary<string, string> userLogins = new Dictionary<string, string>();

        public MainPage()
        {

        // Initializes UI components defined in MainPage.xaml
            InitializeComponent();


            // Reads stored login credentials from a text file
            // Each line is expected to be in the format: "username, password"
            
            StreamReader reader = new StreamReader("../../../../login.txt");
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(", ");
                userLogins.Add(line[0], line[1]);
            }
            reader.Close();
        }

// Handles the login button click event
        // Validates user input and navigates based on authentication results
        
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
                    StreamWriter writer = new StreamWriter("../../../../login.txt", true);
                    writer.WriteLine($"{username}, {password}");
                    writer.Close();
                    await Shell.Current.GoToAsync("//MainItemsPage");
                }
                else if (password != userLogins[username])
                {
                    //incorrect password
                    await DisplayAlert("Login Error", "Incorrect password", "Try Again");
                }
                else
                {

                // Successful login; navigate to the main items page
                    await Shell.Current.GoToAsync("//MainItemsPage");
                }
            }
        }
    }
}
