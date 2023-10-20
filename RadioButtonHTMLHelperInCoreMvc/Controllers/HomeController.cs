using Microsoft.AspNetCore.Mvc;
using RadioButtonHTMLHelperInCoreMvc.Models;
using System.Diagnostics;

namespace RadioButtonHTMLHelperInCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Index()
        {
            Company company = new Company();
            //company.SelectedDepartment = 2;

            return View(company);
        }

        [HttpPost]
        public string Index(Company company)
        {
            if (company.SelectedDepartment <= 0)
            {
                return "You did not select any department";
            }
            else
            {
                return "You selected department with Id = " + company.SelectedDepartment;
            }
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