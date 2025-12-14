namespace FinalProject201
{
    // Page that displays drink menu items and allows users
    // to select quantities before adding them to the cart.
     
    public partial class DrinkPage : ContentPage
    {
        public double waterVal = 0;
        public double colaVal = 0;
        public double coffeeVal = 0;
        public double lemonVal = 0;

        public DrinkPage()
        {
            // Initializes UI components defined in DrinkPage.xaml
            InitializeComponent();
        }

        // Handles changes to any Stepper on the drink page
        // Updates the corresponding button text to reflect the selected quantity
        
        void StepperValChanged(object sender, ValueChangedEventArgs e)
        {
            // Retrieves the new quantity value from the stepper
            double value = e.NewValue;
          
            // Ensure the event sender is a Stepper control
            if (sender is Stepper stepper)
            {
                // Check which drink stepper triggered the event
                if (stepper.Equals(colaStep))
                {
                    UpdateBtnTxt(colaBtn, value);
                    colaVal = value;
                } 
                else if (stepper.Equals(waterStep))
                {
                    // Update water button text
                    UpdateBtnTxt(waterBtn, value);
                    waterVal = value;
                } 
                else if (stepper.Equals(coffeeStep))
                {
                    UpdateBtnTxt(colaBtn, value);
                    coffeeVal = value;
                }
                else if (stepper.Equals(lemonStep))
                { 
                    // Update lemonade button text
                    UpdateBtnTxt(lemonBtn, value);
                    lemonVal = value;
                }
            }  
        }

        // Updates the text of a button based on the selected quantity
        // Provides immediate visual feedback to the user

        void UpdateBtnTxt(Button button, double val)
        {
            button.Text = string.Format("Add {0} to cart", val);
        }
        
        // Logs the user out and navigates back to the main login page
        private async void LogoutClicked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//MainPage");
        }
        // Navigates the user to the checkout page to review their order
        private async void CheckoutClicked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//CheckoutPage");
        }

        private void colaBtn_Clicked(object sender, EventArgs e)
        {
            Drink cola = new Drink
            {
                Name = "Cola",
                Quantity = (int)colaVal,
                Price = 0.99,
                SugarGrams = 44
            };
        }

        private void waterBtn_Clicked(object sender, EventArgs e)
        {
            Drink water = new Drink
            {
                Name = "Water",
                Quantity = (int)waterVal,
                Price = 0.00,
                SugarGrams = 0
            };
        }

        private void coffeeBtn_Clicked(object sender, EventArgs e)
        {
            Drink coffee = new Drink
            {
                Name = "Coffee",
                Quantity = (int)coffeeVal,
                Price = 0.99,
                SugarGrams = 0
            };
        }

        private void lemonBtn_Clicked(object sender, EventArgs e)
        {
            Drink lemonade = new Drink
            {
                Name = "Lemonade",
                Quantity = (int)lemonVal,
                Price = 0.99,
                SugarGrams = 25
            };
        }
    }
}
