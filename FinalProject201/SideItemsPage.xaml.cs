namespace FinalProject201
{
    public partial class SideItemsPage : ContentPage
    {
        public double friesVal = 0;
        public double vegVal = 0;
        public double appleVal = 0;
        public double fruitVal = 0;

        public SideItemsPage()
        {
            InitializeComponent();
        }

        void StepperValChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;

            if (sender is Stepper stepper)
            {
                if (stepper.Equals(friesStep))
                {
                    UpdateBtnTxt(friesBtn, value);
                    friesVal = value;
                }
                else if (stepper.Equals(veggieStep))
                {
                    UpdateBtnTxt(veggieBtn, value);
                }
                else if (stepper.Equals(appleStep))
                {
                    UpdateBtnTxt(appleBtn, value);
                }
                else if (stepper.Equals(fruitStep))
                {
                    UpdateBtnTxt(fruitBtn, value);
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

        private void friesBtn_Clicked(object sender, EventArgs e)
        {
            OrderServices.AddToOrder("Fries");
        }
    }
}
