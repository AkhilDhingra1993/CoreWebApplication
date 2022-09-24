using CoreWebApplication.Models;
using CoreWebApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApplication.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {

        private readonly IOrderRepositiory _orderRepository;
        private readonly IUserRepostory _userRepository;

        public HomeController(IOrderRepositiory orderRepositiory, IUserRepostory userRepository)
        {
            _orderRepository = orderRepositiory;
            _userRepository = userRepository;
        }
        [Route("~/Home")]
        [Route("~/")]
        public ViewResult Index()
        {
            //return _orderRepository.GetOrder(1).PAYMENT_METHOD;
            var model = _orderRepository.GetAllOrders();
            var user = _userRepository.GetAllUsers();
            return View(user);
        }

        [Route("{id?}")]
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Order = _orderRepository.GetOrder(id ?? 1),
                User = _userRepository.GetUser(id ?? 1),
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
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid){
                User newUser = _userRepository.Add(user);
                //return RedirectToAction("Details", new { id = newUser.ID });
            }
            return View();
        }
    }
}
