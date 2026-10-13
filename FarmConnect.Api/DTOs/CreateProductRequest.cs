using System.ComponentModel.DataAnnotations;

namespace FarmConnect.Api.DTOs
{
    public class CreateProductRequest
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;
        [Range(typeof(decimal),"0.01", "10000")]
        public decimal Price { get; set; }
        [Range(0,100)]
        public int Stock { get; set; }
    }
}
