using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Models.Entities;

public class Category
{
    [Key] public int Id { get; set; }

    [Required]
    [StringLength(150, MinimumLength = 3)]
    public string Name { get; set; } = string.Empty;

    [StringLength(500)]
    public string? Description { get; set; }

    public bool IsActive { get; set; } = true;

    public ICollection<Product> Products { get; set; } = new List<Product>();
}