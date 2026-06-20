using Microsoft.EntityFrameworkCore;
using _2526_2221050692_BaiThi.Models;

namespace _2526_2221050692_BaiThi.Data
{
    public class VuVanCuongDbContext : DbContext
    {
        public VuVanCuongDbContext(DbContextOptions<VuVanCuongDbContext> options)
            : base(options)
        {
        }

        public DbSet<LopHoc> LopHocs { get; set; } = null!;
    }
}


