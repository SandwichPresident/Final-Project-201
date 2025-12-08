namespace FinalProject201
{
    public partial class MainItemsPage : ContentPage
    {
        public MainItemsPage()
        {
            InitializeComponent();
        }

        void StepperValChanged(object sender, ValueChangedEventArgs e)
        {
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
