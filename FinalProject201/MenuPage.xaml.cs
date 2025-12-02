namespace FinalProject201
{
    public partial class MenuPage : ContentPage
    {
        int count = 0;

        public MenuPage()
        {
            //InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

        }
    }
}
