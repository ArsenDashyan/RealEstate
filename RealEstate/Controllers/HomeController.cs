using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RealEstate.Models;
using RealEstate.Models.Estate;
using System.Diagnostics;

namespace RealEstate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEstateRepository estateRepository;

        public HomeController(ILogger<HomeController> logger, IEstateRepository estateRepo)
        {
            _logger = logger;
            estateRepository = estateRepo;
        }

        public IActionResult Index() => View(estateRepository.Estates);
        public IActionResult About() => View();
        public IActionResult Contact() => View();
        public IActionResult SignIn() => View();
        public IActionResult LogIn(string login, string passw)
        {

            return RedirectToAction("Index");
        }


        public IActionResult CurrentEstate(int id) => View("EstateDescription", estateRepository.GetEstateById(id));

        public IActionResult CompanyDetail(int id) => View(estateRepository.GetEstateById(id));

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
