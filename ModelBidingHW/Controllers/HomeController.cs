using Microsoft.AspNetCore.Mvc;
using ModelBidingHW.Models;
using System.Diagnostics;

namespace ModelBidingHW.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

		[HttpGet]
		public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(VideoGame g)
        {
            if (ModelState.IsValid)
			{
				//Add to Database
				return RedirectToAction("Index");
			}

            
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}