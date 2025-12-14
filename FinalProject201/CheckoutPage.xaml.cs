using System.Collections.ObjectModel;

namespace FinalProject201
{  
    // Checkout page where users review their selected items
    // and place their final order.
    
    public partial class CheckoutPage : ContentPage
    {
        public CheckoutPage()
        {
            // Initializes UI components defined in CheckoutPage.xaml
            InitializeComponent();
            /*
            order = ordering;
            order.AddToOrder(new Item { Name = "this is for testing", Quantity = 1, Price = 100 });
            */
            // Sets the item source for the checkout list view
            // This determines which items are displayed to the user
            
            //orderedItems.ItemsSource = GetItems();

        }

        // Retrieves the list of items currently in the cart
        // This method demonstrates use of a List<Item> data structure
        /*
        private List<Item> GetItems()
        {
            return order.GetCurrentOrder().Values.ToList();
        }
        */
        private void RemoveItem(object? sender, EventArgs e)
        {
            Console.WriteLine("removing item");
        }

        // Handles the checkout button click event
        // Displays a confirmation message and returns the user to the login page
        
        private async void CheckoutClicked(object? sender, EventArgs e)
        {
            await DisplayAlert("Order placed!", "Thank you for choosing Ritchies!", "Exit");

            // Navigates back to the main login page after checkout
            
            await Shell.Current.GoToAsync("//MainPage");

        }

    }
}
