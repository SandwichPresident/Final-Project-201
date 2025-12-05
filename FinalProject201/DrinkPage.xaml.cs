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
            //right now only first stepper works </3
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
            } 
          
        }

        void UpdateBtnTxt(Button button, double val)
        {
            button.Text = string.Format("Add {0} to cart", val);

        }

    }
}
