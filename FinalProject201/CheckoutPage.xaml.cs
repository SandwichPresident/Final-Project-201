namespace FinalProject201
{
    public partial class CheckoutPage : ContentPage
    {
        private OrderServices currentBasket; 
        public CheckoutPage(OrderServices basket)
        {
            this.currentBasket = basket;
            InitializeComponent();

            
        }



        private async void CheckoutClicked(object? sender, EventArgs e)
        {
            await DisplayAlert("Order placed!", "Thank you for choosing Ritchies!", "Exit");
            await Shell.Current.GoToAsync("//MainPage");

        }

    }
}
