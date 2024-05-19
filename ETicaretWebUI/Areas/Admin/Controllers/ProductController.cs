using ETicaret.Data.Repository;
using ETicaret.Model;
using ETicaret.Model.Models;
using ETicaretWebUI.Data;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public ProductController(IUnitOfWork unit)
        {
            unitOfWork = unit;
        }
        public IActionResult Index()
        {
            List<Product> getirTumproductler = unitOfWork.Product.GetAll().ToList();
            return View(getirTumproductler);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Product.Add(product);
                unitOfWork.Save();
                TempData["basarili"] = product.Title + " " + "Başarılı bir şekilde eklendi";
                return RedirectToAction("Index");
            }

            return View(product);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Product degistirilecekId = unitOfWork.Product.Get(x => x.Id == id);
            if (degistirilecekId == null)
            {
                return NotFound();
            }
            return View(degistirilecekId);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Product.Update(product);
                unitOfWork.Save();
                TempData["basarili"] = product.Title + " " + "Başarılı bir şekilde güncellendi";

                return RedirectToAction("Index");

            }
            return View(product);
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Product? getirSilinecekId = unitOfWork.Product.Get(x => x.Id == id);
            if (getirSilinecekId == null)
            {
                return NotFound();
            }
            return View(getirSilinecekId);


        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            if (product != null)
            {
                unitOfWork.Product.Remove(product);
                unitOfWork.Save();
                TempData["basarili"] = "Başarılı bir şekilde Kaldırıldı";
                return RedirectToAction("Index");

            }
            return View(product);
        }
    }
}
