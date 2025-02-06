using Butik_Test.Models;
using EticaretData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Butik_Test.Controllers
{
    public class HomeController : Controller
    {
        /*

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        */

        private readonly DatabaseContext _context;

        public HomeController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {


            var model = new HomePageViewModel
            {
                Sliders = await _context.Sliders.ToListAsync(),
                Products = await _context.Products.ToListAsync(),
                News = await _context.News.ToListAsync()
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        } 
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult odeme()
        {
            bool odemeBasarili = OdemeCheck();

            if (true)
            {

            }

            return View();
        }

        private bool OdemeCheck()
        {
            return true;
        }

        public IActionResult taksit()
        {
            if ("123" =="1234")
            {

            }
            return View();

            // müþteri controller, ödeme contr ayrý ayrý yap.
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
