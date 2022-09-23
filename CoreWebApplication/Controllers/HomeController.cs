using CoreWebApplication.Models;
using CoreWebApplication.ViewModels;
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
        public ViewResult Index()
        {
            //return _orderRepository.GetOrder(1).PAYMENT_METHOD;
            var model =  _orderRepository.GetAllOrders();
            return View(model);
        }

        public ViewResult Details()
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Order = _orderRepository.GetOrder(1),
                PageTitle = "Order Details"
            };
            //Order order = _orderRepository.GetOrder(1);
            //ViewData["Order"] = order;
            //ViewData["PageTitle"] = "Order Details";
            //ViewBag.PageTitle = "Order Details";
            //return View(order);

            return View(homeDetailsViewModel);
            //return View("..//Test/Details");
        }
    }
}
