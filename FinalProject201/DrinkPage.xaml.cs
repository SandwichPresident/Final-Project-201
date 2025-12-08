namespace FinalProject201
{
    public partial class DrinkPage : ContentPage
    {
        public DrinkPage()
        {
            InitializeComponent();
        }

        void StepperValChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;

          if (sender is Stepper stepper)
            {
                if (stepper.Equals(colaStep))
                {
                    UpdateBtnTxt(colaBtn, value);
                  
                } else if (stepper.Equals(waterStep))
                {
                    UpdateBtnTxt(waterBtn, value);
                } else if (stepper.Equals(coffeeStep))
                {
                    UpdateBtnTxt(colaBtn, value);
                }
                else if (stepper.Equals(lemonStep))
                {
                    UpdateBtnTxt(lemonBtn, value);
                }
            } 
          
        }

        void UpdateBtnTxt(Button button, double val)
        {
            button.Text = string.Format("Add {0} to cart", val);

        }

        private async void LogoutClicked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//MainPage");
        }

        private async void CheckoutClicked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//CheckoutPage");
        }

    }
}
