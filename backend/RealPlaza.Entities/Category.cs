using System.ComponentModel.DataAnnotations;

namespace RealPlaza.Entities
{
    public class Category : EntityBase
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}