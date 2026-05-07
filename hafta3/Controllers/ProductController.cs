using hafta3.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.DependencyResolver;

namespace hafta3.Controllers
{
    public class ProductController : Controller
    {

        private ProductRepository _repository;
        private AppDbContext _context;


        // product listesi ile
        /*public ProductController()
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
        }*/

        // SQLDB crud


        public ProductController(AppDbContext context)
        {
            _context = context;

            if (!_context.Products.Any()) // Eğer table boş ise;
            {
                _context.Products.Add(new Product { Name = "Laptop", Price = 10000, Stok = 10, Color = "Gri" , Description = "Güçlü işlemci ve büyük RAM" , ozellik = "Yüksek performans" });
                _context.Products.Add(new Product { Name = "Telefon", Price = 5000, Stok = 20, Color = "Siyah", Description = "Yüksek kaliteli kamera ve uzun pil ömrü" , ozellik = "Yüksek kaliteli kamera" });
                _context.Products.Add(new Product { Name = "Tablet", Price = 3000, Stok = 15, Color = " Beyaz", Description = "Hafif ve taşınabilir, uzun pil ömrü" , ozellik = "Hafif ve taşınabilir" });

                _context.SaveChanges();
            }
        }

        public IActionResult Index()
        {
            var urunler = _context.Products.ToList();
            return View(urunler);
        }

        public IActionResult SaveProduct(Product newProduct)
        {
         
            _context.Products.Add(newProduct);
            _context.SaveChanges();
            
            TempData["status"] = "The product has been added successfully.";

            return RedirectToAction("Index");
        }

        public IActionResult UpdateProduct(Product newProduct)
        {
         
            _context.Products.Update(newProduct);
            _context.SaveChanges();

            TempData["status"] = "The product has been updated successfully.";

            return RedirectToAction("Index");
        }


        // remove yi context üzerinden yapalım, find ile id ye göre ürünü bulup remove yapacağız, sonra savechanges ile değişiklikleri kaydedelim
        public IActionResult Remove(int id)
        {
            var product = _context.Products.Find(id);
            _context.Products.Remove(product);
            _context.SaveChanges();

            TempData["status"] = "The product has been removed successfully.";

            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            ViewBag.Expire = new Dictionary<string, int>()
            {
                { "1 Month", 1 },
                { "3 Months", 3 },
                { "6 Months", 6 },
                { "1 Year", 12 }
            };
            return View();
        }

        public IActionResult Update(int Id)
        {
            var product = _context.Products.Find(Id);

            ViewBag.Expire = new Dictionary<string, int>()
            {
                { "1 Month", 1 },
                { "3 Months", 3 },
                { "6 Months", 6 },
                { "1 Year", 12 }
            };

            return View(product);
        }

    }
}
