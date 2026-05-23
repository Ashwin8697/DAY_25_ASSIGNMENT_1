using System.ComponentModel.DataAnnotations;

namespace SecureShoppingApp.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        public string Comment { get; set; }

        public int ProductId { get; set; }

        public Product? Product { get; set; }
    }
}