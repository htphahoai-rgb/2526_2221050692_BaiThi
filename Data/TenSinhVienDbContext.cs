using Microsoft.EntityFrameworkCore;

namespace _2526_2221050692_BaiThi.Data
{
    public class TenSinhVienDbContext : DbContext
    {
        public TenSinhVienDbContext(DbContextOptions<TenSinhVienDbContext> options)
            : base(options)
        {
        }

        // Nếu cần thêm thực thể SinhVien, bạn có thể mở rộng tại đây.
    }
}
