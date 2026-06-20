using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2526_2221050692_BaiThi.Models;

public class LopHoc
{
    [Key]
    public string MaLop { get; set; } = null!;

    public string TenLop { get; set; } = null!;
}