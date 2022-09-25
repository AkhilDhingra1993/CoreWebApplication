using Microsoft.AspNetCore.Mvc;

namespace CoreWebApplication.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "404";
                    break;
            }
            return View("NotFound");
        }
    }
}
