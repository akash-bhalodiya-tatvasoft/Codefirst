using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CodeFirstApi.Models;

namespace Inventory.Models.Entities;

public class Order
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("UserProfile")]
    public int UserId { get; set; }

    [Range(0, 100)]
    public int Status { get; set; }

    public decimal TotalAmount { get; set; }

    public UserProfile UserProfile { get; set; } = null!;

    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
