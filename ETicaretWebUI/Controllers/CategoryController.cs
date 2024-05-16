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
                TempData["basarili"] = kategori.Name + " " +"Başarılı bir şekilde eklendi";
                return RedirectToAction("Index");
            }

            return View(kategori);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if(id ==null || id == 0)
            {
                return NotFound();
            }
            Category categoryVeri = applicationDbContext.Categoriler.Find(id);
            if(categoryVeri == null)
            {
                return NotFound();
            }
            return View(categoryVeri);
        }
        [HttpPost]
        public IActionResult Edit(Category kategori)
        {
            if (ModelState.IsValid)
            {
                applicationDbContext.Update(kategori);
                applicationDbContext.SaveChanges();
                TempData["basarili"] = kategori.Name + " " + "Başarılı bir şekilde güncellendi";

                return RedirectToAction("Index");

            }
            return View(kategori);
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if(id ==null || id == 0)
            {
                return NotFound();
            }
            Category? categoryDb = applicationDbContext.Categoriler.Find(id);
            if(categoryDb == null)
            {
                return NotFound();
            }
            return View(categoryDb);

            
        }
        [HttpPost]
        public IActionResult Delete(Category kategori)
        {
            if (kategori != null) 
            {
                applicationDbContext.Categoriler.Remove(kategori);
                applicationDbContext.SaveChanges();
                TempData["basarili"] ="Başarılı bir şekilde Kaldırıldı";
                return RedirectToAction("Index");
            
            }
            return View(kategori);
        }
    }
}
