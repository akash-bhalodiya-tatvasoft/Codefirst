using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models.Entities;

public class Product
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(200, MinimumLength = 2)]
    public string Name { get; set; } = string.Empty;

    [StringLength(500)]
    public string? Description { get; set; }

    [Required]
    public decimal Price { get; set; }

    [Range(0, int.MaxValue)]
    public int Quantity { get; set; }

    public decimal DiscountedPrice { get; set; }

    public DateOnly? DiscountEndOn { get; set; }

    [ForeignKey("Category")]
    public int CategoryId { get; set; }

    public Category Category { get; set; } = null!;

    [StringLength(500)]
    public string? ProductImage { get; set; }

    [StringLength(500)]
    public string? ProductImageUrl { get; set; }
}