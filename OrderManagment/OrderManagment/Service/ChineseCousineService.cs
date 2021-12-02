using OrderManagment.Interfaces;
using OrderManagment.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagment.Service
{
    public class ChineseCousineService : ICousineService
    {
        Queue<Order> ChefOrderQueue = new Queue<Order>();

        static ChineseCousineService chineseCousineService = null;
        public static ChineseCousineService GetInstance()
        {
            if (chineseCousineService == null)
            {
                chineseCousineService = new ChineseCousineService();
            }

            return chineseCousineService;
        }

        public void AddOrderInQueue(Order order)
        {
            ChefOrderQueue.Enqueue(order);
            Console.WriteLine("Order Added in Chienese chef queue");
        }
    }
}
