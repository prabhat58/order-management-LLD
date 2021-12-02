using OrderManagment.Model;
using OrderManagment.Service;
using System;
using System.Collections.Generic;

namespace OrderManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            Food f1 = new Food(1, "Dal", CousineEnum.Indian);
            Food f2 = new Food(2, "Noodles", CousineEnum.Chienese);

            List<Food> foodItemList = new List<Food>();
            foodItemList.Add(f1); foodItemList.Add(f2);
            Order o1 = new Order(1, foodItemList);

            OrderManagementService orderManagementService = OrderManagementService.GetInstance();
            orderManagementService.CreateOrder(o1);
        }
    }
}
