namespace FinalProject201
{
     // Page that displays dessert menu items and allows users
    // to select quantities before adding them to the cart.
     
    public partial class DessertPage : ContentPage
    {
        public DessertPage()
        {

        // Initializes UI components defined in DessertPage.xaml
            InitializeComponent();
        }

// Handles changes to any Stepper on the dessert page
        // Updates the corresponding button text to reflect the selected quantity

        void StepperValChanged(object sender, ValueChangedEventArgs e)
        {

        // Retrieves the new quantity value from the stepper
            double value = e.NewValue;

// Ensure the event sender is a Stepper control

            if (sender is Stepper stepper)
            {

            // Check which dessert stepper triggered the event
                if (stepper.Equals(icecreamStep))
                {
                    UpdateBtnTxt(icecreamBtn, value);

                }
                else if (stepper.Equals(cookieStep))
                {

                 // Update cookie button text
                    UpdateBtnTxt(cookieBtn, value);
                }
              
            }

        }
// Updates the text of a button based on the selected quantity
        // Provides immediate visual feedback to the user
        void UpdateBtnTxt(Button button, double val)
        {
            button.Text = string.Format("Add {0} to cart", val);

        }

        private async void LogoutClicked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//MainPage");
        }


// Navigates the user to the checkout page to review and place the order
        private async void CheckoutClicked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//CheckoutPage");
        }

    }
}

