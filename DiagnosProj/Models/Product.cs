using System.ComponentModel.DataAnnotations;

namespace DiagnosProj.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(5,1000)]
        public decimal Price { get; set; }

        public ProductCategory ProductCategory { get; set; }
    }
}
