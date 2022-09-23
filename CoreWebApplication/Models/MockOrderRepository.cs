using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreWebApplication.Models
{
    public class MockOrderRepository : IOrderRepositiory
    {
        private readonly List<Order> _ordersList;

        public MockOrderRepository()
        {
            _ordersList = new List<Order>() 
            {
                new Order()
                { 
                    ID =1,
                    CUSTOMER_USER_ID=1,
                    AMOUNT_PAID=20,
                    DATE_CREATED=new DateTime(2022,01,01),
                    PAYMENT_METHOD="CASH",
                    CUSTOMER_ADDRESS_STATE="Delhi",
                    CUSTOMER_ADDRESS_COUNTRY="INDIA",
                    CUSTOMER_ADDRESS_ADDRESS_LINE="Delhi",
                    CUSTOMER_ADDRESS_ZIP_CODE=110087,
                    CUSTOMER_ADDRESS_LABEL="Delhi"
                }
            };
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _ordersList;
        }

        public Order GetOrder(int ID)
        {
            return _ordersList.FirstOrDefault(o => o.ID == ID);
        }
    }
}
