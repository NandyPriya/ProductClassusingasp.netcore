using Microsoft.AspNetCore.Mvc;
using ProductDemo.Models;
using System.Diagnostics;
using static ProductDemo.Models.Product;

namespace ProductDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TransientService service;
        public HomeController(ILogger<HomeController> logger, TransientService service)
        {
            _logger = logger;
            this.service = service;
        }
        List<productimplementinterface> service1 = new List<productimplementinterface>();

        public IActionResult Index()
        {
            int transient1 = service.productid();
            service1.Add(new productimplementinterface
            {
                Productid = transient1,
                Productname = "Snacks",
                Quantity = 2
            });

            int transient2 = service.productid();

            service1.Add(new productimplementinterface
            {
                Productid = transient2,
                Productname = "Chocolates",
                Quantity = 10
            });
            int transient3 = service.productid();

            service1.Add(new productimplementinterface
            {
                Productid = transient3,
                Productname = "Biscuits",
                Quantity = 200
            });
            ViewBag.Result = service1;
            return View(service1);
           
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