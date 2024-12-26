using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UnitTest.Models;

namespace UnitTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public string EO(int n)
        {
            if (n % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }

        }

        public int fact(int x)
        {
            int f = 1;
            for (int i = 1; i <=x; i++)
            {
                f = f * i;
            }
            return f;
        }

        public string text()
        {
            return "Priya from BIWW";
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
