using System.Threading.Tasks;
namespace FinalProject201 { 
    public partial class MainPage : ContentPage { 

        int count = 0; 
        public MainPage() { 

            InitializeComponent(); 
        }

        private async void LoginClicked(object? sender, EventArgs e) {
            if (Password.Text != null && Username.Text != null)
            {
            await Shell.Current.GoToAsync("//MainItemsPage"); 

            } else
            {      
                //"please create a username and password!"
                await DisplayAlert("Warning", "Please type a username and password to continue!", "OK");
            }
        }


    } 
}