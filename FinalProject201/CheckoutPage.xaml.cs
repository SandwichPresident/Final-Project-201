using System.Collections.ObjectModel;

namespace FinalProject201
{
    public partial class CheckoutPage : ContentPage
    {
        public OrderServices currentBasket;
        public ObservableCollection<Item> testing;
        public CheckoutPage(OrderServices basket)
        {
            this.currentBasket = basket;
            InitializeComponent();
            testing = new ObservableCollection<Item>
            {
                new Item{Name = "food", Quantity = 2}
            };
            BindingContext = testing;

            
        }

        private void RemoveItem(object? sender, EventArgs e)
        {
            currentBasket.RemoveFromOrder("burger", 1);
        }

        private async void CheckoutClicked(object? sender, EventArgs e)
        {
            await DisplayAlert("Order placed!", "Thank you for choosing Ritchies!", "Exit");
            await Shell.Current.GoToAsync("//MainPage");

        }

    }

    public class Item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
