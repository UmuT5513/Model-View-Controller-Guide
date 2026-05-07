using System.ComponentModel.DataAnnotations;

namespace hafta3.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ürün adı zorunludur.")]
        public string Name { get; set; }

        public int Stok { get; set; }

        [RegularExpression(@"[0-9]{1,2}", ErrorMessage = "Fiyat en fazla 99 olabilir.")]
        public decimal Price { get; set; }

        public string? Color { get; set; }


        public string Description { get; set; }

        public string? ozellik { get; set; }

        public bool isPublished { get; set; }

        public int Expire { get; set; }

        public DateTime? PublishedDate { get; set; }
    }
}