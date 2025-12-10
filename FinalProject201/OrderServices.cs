using System.Collections.Generic;

namespace FinalProject201
{
    public partial class OrderServices
    {
        public List<string> order = new List<string>();

        public void Add(string item, int num)
        {
            while (num > 0)
            {
                order.Add(item);
                num--;
            }
        }

        public void remove(string item, int num)
        {
            while (num > 0)
            {
                order.Remove(item);
                num--;
            }
        }
    }
}
