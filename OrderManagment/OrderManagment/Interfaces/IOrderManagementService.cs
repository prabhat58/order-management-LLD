using OrderManagment.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagment.Interfaces
{
    interface IOrderManagementService
    {
        public int CreateOrder(Order order);

    }
}
