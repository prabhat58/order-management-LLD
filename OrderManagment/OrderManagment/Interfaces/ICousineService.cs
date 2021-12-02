using OrderManagment.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagment.Interfaces
{
    public interface ICousineService
    {
        public void AddOrderInQueue(Order order);
    }
}
