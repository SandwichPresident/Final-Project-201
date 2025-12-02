using System.Threading.Tasks;
namespace FinalProject201 { 
    public partial class MainPage : ContentPage { 

        int count = 0; 
        public MainPage() { 

            InitializeComponent(); 
        }

        private async void SignUpClicked(object? sender, EventArgs e) {
            await Shell.Current.GoToAsync("//LoginPage"); 
        }
    } 
}