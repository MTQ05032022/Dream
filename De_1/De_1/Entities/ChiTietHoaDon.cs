using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace De_1.Entities
{
    [Table("ChiTietHoaDon")]
    public class ChiTietHoaDon
    {
        [Key]
        public Guid MaCthd { get; set; }

        public Guid MaDh { get; set; }
        [ForeignKey("MaDh")]
        public DonHang DonHang { get; set; }

        public Guid MaHh {  get; set; }
        [ForeignKey("MaHh")]
        public HangHoa HangHoa { get; set; }
        public int SoLuong { get; set; }
    }
}
