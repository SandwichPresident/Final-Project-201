namespace FinalProject201
{
    public partial class DessertPage : ContentPage
    {
        public DessertPage()
        {
            InitializeComponent();
        }

        void StepperValChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;

            if (sender is Stepper stepper)
            {
                if (stepper.Equals(icecreamStep))
                {
                    UpdateBtnTxt(icecreamBtn, value);

                }
                else if (stepper.Equals(cookieStep))
                {
                    UpdateBtnTxt(cookieBtn, value);
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
