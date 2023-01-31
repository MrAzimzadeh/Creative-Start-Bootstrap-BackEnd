using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WepApp.Data;
using WepApp.Models;
using WepApp.ViewModels;

namespace WepApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var banner = _context.Banners.ToList().Last();
            //var banner = _context.Banners.ToList().Last();
            //var sonElema = banner[banner.Count() - 1];
            var portfolio = _context.Portfolios.ToList();
            var services = _context.Services.ToList();

            HomeVM homeVM = new()
            {
                Banners = banner,
                Portfolios = portfolio,
                Services = services
            };

            return View(homeVM);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}