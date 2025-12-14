namespace FinalProject201;

public class OrderServices
{
    private Dictionary<string, Item> order = new Dictionary<string, Item>();

    //Add main stepper class here (make it public) if need to

    public void AddToOrder(Item item)
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

    public void RemoveFromOrder(Item item)
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

    public Dictionary<string, Item> GetCurrentOrder()
    {
        return order;
    }
}
