using ETicaret.Data.Repository;
using ETicaret.Model;
using ETicaretWebUI.Data;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository =categoryRepository ;
        }
        public IActionResult Index()
        {
            List<Category> getirTumKategoriler = categoryRepository.GetAll().ToList();
            return View(getirTumKategoriler);
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
                categoryRepository.Add(kategori);
                categoryRepository.Save();
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
            Category degistirilecekId = categoryRepository.Get(x => x.Id == id);
            if(degistirilecekId == null)
            {
                return NotFound();
            }
            return View(degistirilecekId);
        }
        [HttpPost]
        public IActionResult Edit(Category kategori)
        {
            if (ModelState.IsValid)
            {
                categoryRepository.Update(kategori);
                categoryRepository.Save();
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
            Category? getirSilinecekId = categoryRepository.Get(x=>x.Id ==id);
            if(getirSilinecekId == null)
            {
                return NotFound();
            }
            return View(getirSilinecekId);

            
        }
        [HttpPost]
        public IActionResult Delete(Category kategori)
        {
            if (kategori != null) 
            {
                categoryRepository.Remove(kategori);
                categoryRepository.Save();
                TempData["basarili"] ="Başarılı bir şekilde Kaldırıldı";
                return RedirectToAction("Index");
            
            }
            return View(kategori);
        }
    }
}
