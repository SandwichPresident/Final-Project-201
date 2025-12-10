namespace FinalProject201
{
    public partial class SideItemsPage : ContentPage
    {
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
            OrderServices.addToOrder("fries", friesStep.value);
        }
    }
}
