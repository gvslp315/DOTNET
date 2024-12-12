using System.Diagnostics;
using HMS_Entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace HMS_Entity.Controllers
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
        public IActionResult ShowData()
        {
            return RedirectToAction("Index","Hospitals");
        }
        public IActionResult CreateDoctor(string Doctor,string Qualification,string Specialist)
        {
            TempData["Doctor"] = Doctor;
            TempData["Qualification"]=Qualification;
            TempData["Specialist"] = Specialist;
            return RedirectToAction("Create", "Hospitals");
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
