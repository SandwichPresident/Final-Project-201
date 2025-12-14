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
                    vegVal = value;
                }
                else if (stepper.Equals(appleStep))
                {
                    UpdateBtnTxt(appleBtn, value);
                    appleVal = value;
                }
                else if (stepper.Equals(fruitStep))
                {
                    UpdateBtnTxt(fruitBtn, value);
                    fruitVal = value;
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
            Item fries = new Item
            {
                Name = "Fries",
                Quantity = (int)friesVal,
                Price = 2.99
            };
        }

        private void veggieBtn_Clicked(object sender, EventArgs e)
        {
            Item fries = new Item
            {
                Name = "Veggies",
                Quantity = (int)vegVal,
                Price = 1.99
            };

        }

        private void appleBtn_Clicked(object sender, EventArgs e)
        {
            Item fries = new Item
            {
                Name = "Apple Sauce",
                Quantity = (int)appleVal,
                Price = 0.99
            };
        }

        private void fruitBtn_Clicked(object sender, EventArgs e)
        {
            Item fries = new Item
            {
                Name = "Fruit Cup",
                Quantity = (int)fruitVal,
                Price = 1.99
            };
        }
    }
}
