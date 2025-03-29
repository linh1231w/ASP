using Microsoft.EntityFrameworkCore;
using NguyenthimylinhB2.Model;

namespace NguyenthimylinhB2.Data
{
    public class AppDbContext : DbContext // Kế thừa DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; } // Thêm bảng Category
    }
}
