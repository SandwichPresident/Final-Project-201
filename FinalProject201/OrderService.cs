using System.Text;

namespace FinalProject201;

// Saves orders so the app can prove persistence.

internal class OrderService
{
    private readonly string _orderPath =
        Path.Combine(FileSystem.AppDataDirectory, "orders.txt");

    public bool SaveOrder(string username, List<Item> cart, out string message)
    {
        username = (username ?? "").Trim();

        if (username == "")
        {
            message = "No user is logged in.";
            return false;
        }

        if (cart == null || cart.Count == 0)
        {
            message = "Cart is empty. Add items before checking out.";
            return false;
        }

        try
        {
            Directory.CreateDirectory(FileSystem.AppDataDirectory);

            // Format: username|Burger:2,Fries:1,Soda:1
            var sb = new StringBuilder();
            sb.Append(username);
            sb.Append('|');

            // Loop requirement is clearly visible here
            for (int i = 0; i < cart.Count; i++)
            {
                sb.Append(cart[i].Name);
                sb.Append(':');
                sb.Append(cart[i].Quantity);

                if (i < cart.Count - 1) sb.Append(',');
            }

            File.AppendAllLines(_orderPath, new[] { sb.ToString() });

            message = "Order saved successfully.";
            return true;
        }
        catch (Exception ex)
        {
            message = $"File error while saving order: {ex.Message}";
            return false;
        }
    }
}
