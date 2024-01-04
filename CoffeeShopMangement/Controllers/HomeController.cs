using CoffeeShopMangement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShopMangement.Models;
using CoffeeShopMangement.ModelViews;

namespace CoffeeShopMangement.Controllers
{
    public class HomeController : Controller
    {
        CoffeeShopManagementContext db = new CoffeeShopManagementContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HomeViewVM model = new HomeViewVM();
            var lsProduct = db.Products.ToList();
            var lstintuc = db.TinDangs.ToList();
            var lsCate = db.Categories.ToList();
            model.Products = lsProduct;
            model.TinTucs = lstintuc;
            model.categories = lsCate;
            return View(model);
        }


        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult About()
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
