using WepApp.Models;

namespace WepApp.ViewModels
{
    public class HomeVM
    {
        public Banner Banners { get; set; }
        public List<Portfolio> Portfolios { get; set; }
        public List<Service> Services { get; set; }

    }
}
