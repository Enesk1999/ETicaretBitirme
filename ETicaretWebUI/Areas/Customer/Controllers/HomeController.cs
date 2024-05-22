using ETicaret.Data.Repository;
using ETicaret.Model;
using ETicaret.Model.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ETicaretWebUI.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork unitOfWork;

        public HomeController(ILogger<HomeController> logger,IUnitOfWork unit)
        {
            _logger = logger;
            unitOfWork = unit;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> urunListe = unitOfWork.Product.GetAll(includeProperties:"Category");
            return View(urunListe);
        }
        public IActionResult Details(int id)
        {
            Product getirDetayId = unitOfWork.Product.Get(x => x.Id == id,includeProperties:"Category");

            return View(getirDetayId);
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
