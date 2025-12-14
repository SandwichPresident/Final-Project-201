using System.Text;

namespace FinalProject201;

// Handles saving order data to disk using lists and loops.
internal static class OrderPersistence
{
    private static string OrderPath =>
        Path.Combine(FileSystem.AppDataDirectory, "orders.txt");

    public static bool SaveOrder(string username, List<Item> items, out string message)
    {
        if (items == null || items.Count == 0)
        {
            message = "No items to save.";
            return false;
        }

        try
        {
            Directory.CreateDirectory(FileSystem.AppDataDirectory);

            var builder = new StringBuilder();
            builder.Append(username);
            builder.Append("|");

            // Loop requirement clearly visible
            for (int i = 0; i < items.Count; i++)
            {
                builder.Append(items[i].Name);
                builder.Append(":");
                builder.Append(items[i].Quantity);

                if (i < items.Count - 1)
                    builder.Append(",");
            }

            File.AppendAllLines(OrderPath, new[] { builder.ToString() });

            message = "Order saved.";
            return true;
        }
        catch (Exception ex)
        {
            message = $"Order save failed: {ex.Message}";
            return false;
        }
    }
}
