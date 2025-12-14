
namespace FinalProject201;

// Represents a single menu item in the application.
// This class is used in:
// 1) The menu lists
// 2) The cart list

public class Item
{
    // Name of the food item (ex: Burger, Fries, Soda)
    public string Name { get; set; }

    // Quantity of this item added to the cart
    // Used during checkout calculations and loops
    public int Quantity { get; set; }

    // Optional price field for checkout totals (safe addition)
    // If not used yet, it does NOT break existing code
    public double Price { get; set; }

    // Constructor for basic item usage
    //public Item(string name, int quantity = 1, double price = 0m)
    //{
    //    Name = name;
    //    Quantity = quantity;
    //    Price = price;
    //}

    // Helpful for debugging, logging, and file saving
    public override string ToString()
    {
        return $"{Name} x{Quantity}";
    }
}
// added child class of item for drinks, contains the amount of sugar in grams
public class Drink : Item
{
    public int SugarGrams { get; set; }

    public override string ToString()
    {
        return $"{Name} x{Quantity}";
    }
}