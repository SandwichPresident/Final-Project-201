namespace FinalProject201
{
      // Page responsible for displaying main food items
    // and allowing users to select quantities before checkout.
     
    public partial class MainItemsPage : ContentPage
    {
        OrderServices order;
        public MainItemsPage(OrderServices ordering)
        {
        // Initializes UI components defined in MainItemsPage.xaml
            InitializeComponent();
            order = ordering;
        }


// Handles changes to any Stepper on the page
        // Updates the corresponding button text to reflect quantity selected
        
        void StepperValChanged(object sender, ValueChangedEventArgs e)
        {
        // New value from the stepper (quantity)
            double value = e.NewValue;

            if (sender is Stepper stepper)
            {
                if (stepper.Equals(burgerStep))
                {
                    UpdateBtnTxt(burgerBtn, value);

                }
                else if (stepper.Equals(pizzaStep))
                {
                    UpdateBtnTxt(pizzaBtn, value);
                }
                else if (stepper.Equals(saladStep))
                {
                    UpdateBtnTxt(saladBtn, value);
                }
            }

        }
        
// Updates the text of a button based on the selected quantity
        // This provides immediate visual feedback to the user
        
        void UpdateBtnTxt(Button button, double val)
        {
            button.Text = string.Format("Add {0} to cart", val);

        }
// Logs the user out and navigates back to the login page
        private async void LogoutClicked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//MainPage");
        }


        private void AddToBasket(object? sender, EventArgs e)
        {
            order.AddToOrder(new Item { Name = "Burger", Quantity = 1, Price = 7.99 });
        }

// Navigates the user to the checkout page
// where they can review and place their order

        private async void CheckoutClicked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//CheckoutPage");
        }

    }
}
