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


// Sets the item source for the checkout list view
            // This determines which items are displayed to the user
            
            orderedItems.ItemsSource = getItems();

        }

// Retrieves the list of items currently in the cart
        // This method demonstrates use of a List<Item> data structure
        

        private List<Item> getItems()
        {
            return new List<Item>
            {
                new Item{ Name = "please work", Quantity = 2, Price=2},
                new Item{ Name = "i swear", Quantity=2, Price=2.1}
            };
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
