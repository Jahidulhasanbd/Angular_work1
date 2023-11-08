using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Angular_First__work.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        [Required]
        public string ItemName { get; set; } = default!;
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public int Stock { get; set; }
    }
    public class ItemDbContext : DbContext
    {
        public ItemDbContext(DbContextOptions<ItemDbContext>options):base(options) { }
        public DbSet<Item>Items { get; set; }
    }
}
