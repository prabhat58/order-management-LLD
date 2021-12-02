using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagment.Model
{
    public class Order
    {
        public int OrderId;
        public int GetOrderId() { return OrderId; }
        public void SetOrderId(int orderId) { OrderId = orderId; }

        List<Food> Items = new List<Food>();
        public List<Food> GetFoodItems() { return Items; }
        public void SetFoodItems(List<Food> foodItems) { Items = foodItems; }

        public Order(int orderId, List<Food> foodItems)
        {
            OrderId = orderId;
            Items = foodItems;
        }
    }
}
