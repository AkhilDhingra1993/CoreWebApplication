using CoreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from MVC";
        }
        //private IOrderRepositiory _orderRepository;
        //public HomeController(IOrderRepositiory orderRepositiory)
        //{
        //    _orderRepository=orderRepositiory;
        //}
        //public string Index()
        //{
        //    return _orderRepository.GetOrder(1).PAYMENT_METHOD;
        //}
    }
}
