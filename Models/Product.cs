using System.ComponentModel.DataAnnotations;

namespace AspnetCoreCRUDApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Range(0, 999999)]
        public decimal Price { get; set; }

        [StringLength(1000)]
        public string? Description { get; set; }
    }
}
