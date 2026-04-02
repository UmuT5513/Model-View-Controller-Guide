namespace hafta3.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Stok { get; set; }

        public decimal Price { get; set; }
    
        public string? Color { get; set; }
    
        public int? Height { get; set; }

        public int? Weight { get; set; }
        // ? işareti değerlerin null olabileceğini gösterir.    

    }


}
