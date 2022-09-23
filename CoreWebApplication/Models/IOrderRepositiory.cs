using System.Collections;
using System.Collections.Generic;

namespace CoreWebApplication.Models
{
    public interface IOrderRepositiory
    {
        Order GetOrder(int ID);
        IEnumerable<Order> GetAllOrders();
    }
}
