using System.Collections.ObjectModel;

namespace FinalProject201;

public static class OrderServices
{
    public static Dictionary<string, int> order = new Dictionary<string, int>();
    public static ObservableCollection<Item> items = new ObservableCollection<Item>();
    public static int index = 0;

    //Add main stepper class here (make it public) if need to

    public static void AddToOrder(Item item)
    {
        if (order.ContainsKey(item.Name))
        {
            item.Quantity += items.ElementAt(order[item.Name]).Quantity;
            items[order[item.Name]] = item;
        }
        else
        {
            order[item.Name] = index;
            index++;
            items.Add(item);
        }
       
    }

    public static double GetTotalPrice()
    {
        double total = 0;
        foreach (Item item in items)
        {
            total += item.Price;
        }
        return total;
    }

    public static void Checkout()
    {
        order = new Dictionary<string, int>();
        items.Clear();
    }

    public static ObservableCollection<Item> GetCurrentOrder()
    {
        return items;
    }
}
