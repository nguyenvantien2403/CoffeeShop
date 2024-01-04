using CoffeeShopMangement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PagedList.Core;
using System.Linq;

namespace CoffeeShopMangement.Controllers
{
    public class BlogController : Controller
    {
        CoffeeShopManagementContext db = new CoffeeShopManagementContext();
        private readonly CoffeeShopManagementContext _context;
        private readonly ILogger<HomeController> _logger;
        public BlogController(CoffeeShopManagementContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        [Route("blogs.html", Name = ("Blog"))]
        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 4;
            var lsTinDangs = _context.TinDangs
                .AsNoTracking()
                .OrderBy(x => x.PostId);
            PagedList<TinDang> models = new PagedList<TinDang>(lsTinDangs, pageNumber, pageSize);

            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }

        [Route("/tin-tuc/{Alias}-{id}.html", Name = "TinChiTiet")]
        public IActionResult Details(int id)
        {
            var tindang = _context.TinDangs.AsNoTracking().SingleOrDefault(x => x.PostId == id);
            if (tindang == null)
            {
                return RedirectToAction("Index");
            }
            var lsBaivietlienquan = _context.TinDangs
                .AsNoTracking()
                .Where(x => x.Published == true && x.PostId != id)
                .Take(3)
                .OrderByDescending(x => x.CreatedDate).ToList();
            ViewBag.Baivietlienquan = lsBaivietlienquan;
            return View(tindang);
        }
    }
}
