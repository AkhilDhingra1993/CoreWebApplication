using CoreWebApplication.Models;
using CoreWebApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApplication.Controllers
{
    public class HomeController : Controller
    {

        private readonly IOrderRepositiory _orderRepository;
        private readonly IUserRepostory _userRepository;

        public HomeController(IOrderRepositiory orderRepositiory, IUserRepostory userRepository)
        {
            _orderRepository = orderRepositiory;
            _userRepository = userRepository;
        }
        public ViewResult Index()
        {
            //return _orderRepository.GetOrder(1).PAYMENT_METHOD;
            var model =  _orderRepository.GetAllOrders();
            var user = _userRepository.GetAllUser();

            return View(user);
        }

        public ViewResult Details()
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Order = _orderRepository.GetOrder(1),
                User = _userRepository.GetUser(1),
                PageTitle = "User Details",
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
