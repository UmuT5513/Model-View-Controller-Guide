namespace hafta3.Models
{
    public class ProductRepository
    {
        private static List<Product> _products = new List<Product>();

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public void Add(Product yeniUrun)
        {
            _products.Add(yeniUrun);
        }

        public void Remove(int id)
        {
            var hasProduct = _products.FirstOrDefault(temp => temp.Id == id);

            if (hasProduct == null)
                @* ürün bulunamadı *@
                throw new Exception($"{id}'li ürün bulunamadı");

            _products.Remove(hasProduct);
        }
    }
}
