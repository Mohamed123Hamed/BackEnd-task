using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendTask.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productId { get; set; }
        [Required]
        [MinLength(3,ErrorMessage = "Product name is required and must be at least 3 characters long")]
        public string Name { get; set; }
        [MaxLength(500,ErrorMessage ="product description cant be exceed 500 characters")]
        public string? description { get; set; }
        
        [Required]
        [Range(0.01,Double.MaxValue,ErrorMessage ="Product Price is required and must be at least 0.01")]
        public double price { get; set; }
        
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "stockquantity is required and must be a non negative value")]
        public int stockQuantity { get; set; }

        public DateTime? createDate { get; set; }

    }
}
