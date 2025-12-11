using System.Collections.Generic;

namespace FinalProject201
{
    public class OrderServices
    {
        private List<string> order = new List<string>();

        //Add main stepper class here (make it public) if need to

        public void AddToOrder(string item, double num)
        {
            while (num > 0)
            {
                order.Add(item);
                num--;
            }
        }

        public void RemoveFromOrder(string item, double num)
        {
            while (num > 0)
            {
                order.Remove(item);
                num--;
            }
        }

        public List<string> GetCurrentOrder()
        {
            return order;
        }
    }
}
