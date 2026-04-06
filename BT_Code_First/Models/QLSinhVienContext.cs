using Microsoft.EntityFrameworkCore;

namespace BT_Code_First.Models
{
    public class QLSinhVienContext : DbContext
    {
        public QLSinhVienContext(DbContextOptions<QLSinhVienContext> options)
            : base(options)
        {
        }

        public DbSet<SinhVien> SinhViens { get; set; }
    }
}