using CoreWebApplication.Models;

namespace CoreWebApplication.ViewModels
{
    //DTO
    public class HomeDetailsViewModel
    {
        public Order Order { get; set; }
        public string PageTitle { get; set; }
        public User User { get; set; }
    }
}
