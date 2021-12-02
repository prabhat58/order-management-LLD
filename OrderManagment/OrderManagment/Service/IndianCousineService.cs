using OrderManagment.Interfaces;
using OrderManagment.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagment.Service
{
    public class IndianCousineService : ICousineService
    {
        Queue<Order> ChefOrderQueue = new Queue<Order>();

        static IndianCousineService indianCousineService = null;
        public static IndianCousineService GetInstance()
        {
            if (indianCousineService == null)
            {
                indianCousineService = new IndianCousineService();
            }

            return indianCousineService;
        }

        public void AddOrderInQueue(Order order)
        {
            ChefOrderQueue.Enqueue(order);
            Console.WriteLine("Order Added in Indian chef queue");
        }
    }
}
