using System.Collections.Generic;

namespace FinalProject201
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void CheckoutClicked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//CheckoutPage");
        }

        private void Burger_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}
