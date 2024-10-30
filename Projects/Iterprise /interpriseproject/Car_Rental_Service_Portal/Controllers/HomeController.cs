using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Car_Rental_Service_Portal.Models;


namespace Car_Rental_Service_Portal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Action method for the Home page
        public IActionResult Index()
        {
            return View();
        }

        // Action method for the Privacy page
        public IActionResult Privacy()
        {
            return View();
        }

        // Action method for displaying profiles and cars
        public IActionResult ProfilesAndCarsView()
        {
            // Sample data
            var profiles = new List<Profile>
        {
            new Profile { Username = "user1", IsAdmin = true },
            new Profile { Username = "user2", IsAdmin = false }
        };

            var cars = new List<Car>
        {
            new Car { CarId = 1, Brand = "Tesla", Year = 2020, IsElectric = true },
            new Car { CarId = 2, Brand = "Toyota", Year = 2018, IsElectric = false }
        };

            var viewModel = new ProfileCarViewModel
            {
                Profiles = profiles,
                Cars = cars
            };

            return View(viewModel);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
    //  dddd