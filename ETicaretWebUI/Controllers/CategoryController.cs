using ETicaretWebUI.Data;
using ETicaretWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;
        public CategoryController(ApplicationDbContext applicationDb)
        {
            applicationDbContext = applicationDb;
        }
        public IActionResult Index()
        {
            List<Category> obj = applicationDbContext.Categoriler.ToList();
            return View(obj);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category kategori)
        {
            if (ModelState.IsValid)
            {
                applicationDbContext.Add(kategori);
                applicationDbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kategori);
        }
        public IActionResult Edit()
        {
            return View();
        }
        //public IActionResult Create()
        //{
        //    return View();
        //}
        public IActionResult Delete()
        {
            return View();
        }
        //public IActionResult Create()
        //{
        //    return View();
        //}
    }
}
