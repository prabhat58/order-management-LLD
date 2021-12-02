using OrderManagment.Interfaces;
using OrderManagment.Model;

namespace OrderManagment.Service
{
    public class OrderManagementService : IOrderManagementService
    {
        static OrderManagementService orderManagementService = null;
        IndianCousineService indianCousineService = IndianCousineService.GetInstance();
        ChineseCousineService chineseCousineService = ChineseCousineService.GetInstance();

        public static OrderManagementService GetInstance()
        {
            if (orderManagementService == null)
            {
                orderManagementService = new OrderManagementService();
            }

            return orderManagementService;
        }


        public int CreateOrder(Order order)
        {
            foreach (Food food in order.GetFoodItems())
            {
                if (food.CousineType == CousineEnum.Indian)
                {
                    indianCousineService.AddOrderInQueue(order);
                }
                else if (food.CousineType == CousineEnum.Chienese)
                {
                    chineseCousineService.AddOrderInQueue(order);
                }
            }


            return order.OrderId;
        }

    }
}
