using CoreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApplication.Controllers
{
    public class HomeController : Controller
    {

        private readonly IOrderRepositiory _orderRepository;
        public HomeController(IOrderRepositiory orderRepositiory)
        {
            _orderRepository = orderRepositiory;
        }
        public string Index()
        {
            return _orderRepository.GetOrder(1).PAYMENT_METHOD;
        }

        public ObjectResult Details()
        {
            Order order = _orderRepository.GetOrder(1);
            return new ObjectResult(order);
        }
    }
}
