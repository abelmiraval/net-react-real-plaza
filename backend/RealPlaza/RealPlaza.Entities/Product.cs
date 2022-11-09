using System;
using System.ComponentModel.DataAnnotations;

namespace RealPlaza.Entities
{
    public class Product : EntityBase
    {
        [Required] 
        [StringLength(100)] 
        public string Name { get; set; }
        [Required] 
        public decimal Price { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
