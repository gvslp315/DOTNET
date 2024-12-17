using System.Diagnostics;
using HMS_Entity.Models;
using Microsoft.AspNetCore.Mvc;

//using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HMS_Entity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly HospitalDBContext _context;

        public HomeController(ILogger<HomeController> logger, HospitalDBContext context)
        {
            _logger = logger;

            _context = context;

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowData()
        {
            return RedirectToAction("Index", "Hospitals");
        }
        public IActionResult CreateDoctor(string Doctor, string Qualification, string Specialist)
        {
            TempData["Doctor"] = Doctor;
            TempData["Qualification"] = Qualification;
            TempData["Specialist"] = Specialist;
            return RedirectToAction("Create", "Hospitals");
        }
        
        public IActionResult ShowMedical(string pName, string dName)
         {
            // Store the patient and disease name in TempData
            TempData["pName"] = pName;
                TempData["dName"] = dName;

           int n= _context.Hospital.Count();

            var medicalShops = (from hospital in _context.Hospital
                                join medical in _context.Medical on hospital.mId equals medical.mId
                                where hospital.Specialist == dName
                                select medical.mName);
            var medShop=string.Empty;
            foreach(var ms in medicalShops)
            {
                medShop = ms;
            }


            TempData["shpName"] = $"Patient {pName} is the best {medShop} for the {dName}";

            return RedirectToAction("Doctors", "Home");
    }
        public IActionResult Doctors()
        {
            return View();
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
