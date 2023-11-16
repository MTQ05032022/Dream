using Microsoft.EntityFrameworkCore;

namespace De_1.Entities
{
    public class MyDbContext : DbContext
    {
        public DbSet<Loai> Loais { get; set; }
        public DbSet<HangHoa> HangHoas { get; set;}
        public DbSet<DonHang> DonHangs { get; set; }

        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }


        public MyDbContext(DbContextOptions options):base(options)
        {

        }
        
    }
}
