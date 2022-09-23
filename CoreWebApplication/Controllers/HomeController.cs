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

        public ViewResult Details()
        {
            Order order = _orderRepository.GetOrder(1);
            ViewData["Order"] = order;
            //ViewData["PageTitle"] = "Order Details";
            ViewBag.PageTitle = "Order Details";
            //return View(order);
            return View("Details");
            //return View("..//Test/Details");
        }
    }
}
