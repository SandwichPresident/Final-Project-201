using System.Collections.Generic;

namespace FinalProject201
{
    public partial class MenuPage : ContentPage
    {
        List<string> order = new List<string>();

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
            order.Add("burger");
        }

        public void addToOrder(string item)
        {
            order.Add(item);
        }
    }
}
