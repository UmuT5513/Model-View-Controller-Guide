using hafta3.Models;
using Microsoft.AspNetCore.Mvc;

namespace hafta3.Controllers
{
    public class ProductController : Controller
    {

        private ProductRepository _repository;

        public ProductController()
        {
            _repository = new ProductRepository();
            if(!_repository.GetAllProducts().Any()) // Eğer repo boş ise;
            {
                _repository.Add(new Product { Id = 1, Name = "Laptop", Price = 10000, Stok = 10 });
                _repository.Add(new Product { Id = 2, Name = "Telefon", Price = 5000, Stok = 20 });
                _repository.Add(new Product { Id = 3, Name = "Tablet", Price = 3000, Stok = 15 });
                }
        }
        public IActionResult Index()
        {
            var urunler = _repository.GetAllProducts();
            return View(urunler);
        }

        public IActionResult Remove(int id)
        {
            _repository.Remove(id);
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Update(int Id)
        {
            return View();
        }
        
    }
}
