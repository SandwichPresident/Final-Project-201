namespace FinalProject201
{
    // Page responsible for displaying main food items
    // and allowing users to select quantities before checkout.
     
    public partial class MainItemsPage : ContentPage
    {
        public double burgerVal = 0;
        public double pizzaVal = 0;
        public double saladVal = 0;

        public MainItemsPage()
        {
            // Initializes UI components defined in MainItemsPage.xaml
            InitializeComponent();
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
                    burgerVal = value;
                }
                else if (stepper.Equals(pizzaStep))
                {
                    UpdateBtnTxt(pizzaBtn, value);
                    pizzaVal = value;
                }
                else if (stepper.Equals(saladStep))
                {
                    UpdateBtnTxt(saladBtn, value);
                    saladVal = value;
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

        // Navigates the user to the checkout page
        // where they can review and place their order
        private async void CheckoutClicked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//CheckoutPage");
        }

        private void burgerBtn_Clicked(object sender, EventArgs e)
        {
            Item burger = new Item
            {
                Name = "Burger",
                Quantity = (int)burgerVal,
                Price = 3.99
            };
            OrderServices.AddToOrder(burger);
        }

        private void pizzaBtn_Clicked(object sender, EventArgs e)
        {
            Item pizza = new Item
            {
                Name = "Pizza",
                Quantity = (int)pizzaVal,
                Price = 1.99
            };
            OrderServices.AddToOrder(pizza);
        }

        private void saladBtn_Clicked(object sender, EventArgs e)
        {
            Item salad = new Item
            {
                Name = "Salad",
                Quantity = (int)saladVal,
                Price = 2.49
            };
            OrderServices.AddToOrder(salad);
        }
    }
}
