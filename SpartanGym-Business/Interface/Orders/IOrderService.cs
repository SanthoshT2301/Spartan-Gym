using System;
using System.Collections.Generic;
using System.Text;
using SpartanGym_Core.DTO;

namespace SpartanGym_Business.Interface.Orders
{

    //GetAllUserOrderHistory
    //GetMyOrder


//AddItems
//RemoveItems

    public interface IOrderService
    {
        public Task<List<OrderDto>> GetAllUserOrderHistory();
        public Task<List<OrderDto>> GetMyOrder(int id);

        public Task<bool> AddItems(OrderDto cart);
        public Task<bool> DeleteItems(int id);
    }
}
