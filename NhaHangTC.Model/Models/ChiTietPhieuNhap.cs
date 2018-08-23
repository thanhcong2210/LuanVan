using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhaHangTC.Model.Models
{

    [Table("MenuGroups")]
    public class ChiTietPhieuNhap
    {
        [Key]
        [Column(Order = 1)]
        public int MATHUCPHAM { set; get; }

        [ForeignKey("MATHUCPHAM")]
        public virtual ThucPham ThucPham { set; get; }

        [Key]
        [Column(Order = 2)]
        public int MAPHIEUNHAP { set; get; }

        [ForeignKey("MAPHIEUNHAP")]
        public virtual PhieuNhap PhieuNhap { set; get; }

        [Key]
        [Column(Order = 3)]
        public int MATAIKHOAN { set; get; }

        [ForeignKey("MATAIKHOAN")]
        public virtual TaiKhoan TaiKhoan { set; get; }

        [Required]
        [MaxLength(50)]
        public int SOLUONGNHAP { set; get; }

        [Required]
        public float DONGIANHAP { set; get; }

        public virtual IEnumerable<ChiTietPhieuNhap> ChiTietPhieuNhaps { set; get; }
    }
}
