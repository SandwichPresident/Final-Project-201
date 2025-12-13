using System.Collections.ObjectModel;

namespace FinalProject201
{
    public partial class CheckoutPage : ContentPage
    {
    
        public CheckoutPage()
        {
            InitializeComponent();

            orderedItems.ItemsSource = getItems();

        }

        private List<Item> getItems()
        {
            return new List<Item>
            {
                new Item{ Name = "please work", Quantity = 2},
                new Item{ Name = "i swear", Quantity=2}
            };
        }
        private async void CheckoutClicked(object? sender, EventArgs e)
        {
            await DisplayAlert("Order placed!", "Thank you for choosing Ritchies!", "Exit");
            await Shell.Current.GoToAsync("//MainPage");

        }

    }
}
