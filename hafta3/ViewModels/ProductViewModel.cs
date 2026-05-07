namespace hafta3.ViewModels
{
    internal class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Stok { get; set; }

        public decimal Price { get; set; }

        public string? Color { get; set; }


        public string Description { get; set; }

        public string? ozellik { get; set; }

        public bool isPublished { get; set; }

        public int Expire { get; set; }

        public DateTime? PublishedDate { get; set; }
    }
}