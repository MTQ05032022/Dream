using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace De_1.Entities
{
    [Table("DonHang")]
    public class DonHang
    {
        [Key]
        public Guid MaDh { get; set; }

        public DateTime NgayDat { get; set; }
        public string NguoiDat { get; set; }

        public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public DonHang()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }
    }
}
