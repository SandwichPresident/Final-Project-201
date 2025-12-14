namespace FinalProject201;

public static class OrderServices
{
    public static Dictionary<string, Item> order = new Dictionary<string, Item>();

    //Add main stepper class here (make it public) if need to

    public static void AddToOrder(Item item)
    {
        if (order.ContainsKey(item.Name))
        {
            item.Quantity += order[item.Name].Quantity;
            order[item.Name] = item;
        }
        else
        {
            order[item.Name] = item;
        }
       
    }

    public static void RemoveFromOrder(Item item)
    {
        if (order.ContainsKey(item.Name))
        {
            item.Quantity -= order[item.Name].Quantity;
            if (item.Quantity <= 0)
            {
                order.Remove(item.Name);
            }
            else
            {
                order[item.Name] = item;
            }
            
        }
    }

    public static Dictionary<string, Item> GetCurrentOrder()
    {
        return order;
    }
}
