using System.ComponentModel.DataAnnotations;

namespace FiorelloClone.Models;

public class Category : BaseEntity
{
    [Required]
    public string Name { get; set; } = null!;
    public ICollection<Product>? Products { get; set; }
}
