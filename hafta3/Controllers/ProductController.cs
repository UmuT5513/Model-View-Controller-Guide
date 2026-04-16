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
                _context.Products.Add(new Product { Id = 1, Name = "Laptop", Price = 10000, Stok = 10 });
                _context.Products.Add(new Product { Id = 2, Name = "Telefon", Price = 5000, Stok = 20 });
                _context.Products.Add(new Product { Id = 3, Name = "Tablet", Price = 3000, Stok = 15 });

                _context.SaveChanges();
            }
        }

        public IActionResult Index()
        {
            var urunler = _context.Products.ToList();
            return View(urunler);
        }

        public IActionResult SaveProduct()
        {
            var name = HttpContext.Request.Form["product-name"].ToString();
            var price = decimal.Parse(HttpContext.Request.Form["product-price"].ToString());
            var stok = int.Parse(HttpContext.Request.Form["product-stok"].ToString());
            var color = HttpContext.Request.Form["product-color"].ToString();
            var description = HttpContext.Request.Form["product-description"].ToString();
            var ozellik = HttpContext.Request.Form["product-ozellik"].ToString();

            var newProduct = new Product
            {
                Name = name,
                Price = price,
                Stok = stok,
                Color = color,
                Description = description,
                ozellik = ozellik
            };

            _context.Products.Add(newProduct);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        // remove yi context üzerinden yapalım, find ile id ye göre ürünü bulup remove yapacağız, sonra savechanges ile değişiklikleri kaydedelim
        public IActionResult Remove(int id)
        {
            var product = _context.Products.Find(id);
            _context.Products.Remove(product);
            _context.SaveChanges();

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
