using System.Threading.Tasks;
namespace FinalProject201 { 
    public partial class MainPage : ContentPage { 

        int count = 0; 
        public MainPage() { 

            InitializeComponent(); 
        }

        private async void SignUpClicked(object? sender, EventArgs e) {
            if (CreatePass.Text != null && CreateUser.Text != null)
            {
            await Shell.Current.GoToAsync("//LoginPage"); 

            } else
            {      
                //"please create a username and password!"
                await DisplayAlert("Warning", "Please create a username and password to continue!", "OK");
            }
        }
        private async void ToLoginClicked(object? sender, EventArgs e)
        {
             await Shell.Current.GoToAsync("//LoginPage");
           
        }

    } 
}