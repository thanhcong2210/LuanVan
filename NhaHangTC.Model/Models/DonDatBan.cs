using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhaHangTC.Model.Models
{


    [Table("DONDATBAN")]
    public class DonDatBan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MADONDAT { set; get; }

        [Required]
        public int SOLUONGNGUOI { set; get; }

        [Required]
        public DateTime NGAYDEN { set; get; }

        [Required]
        public DateTime GIODEN { set; get; }

        [Required]
        public bool TRANGTHAIDONDAT { set; get; }

        [Required]
        public int MATAIKHOAN { set; get; }

        [ForeignKey("MATAIKHOAN")]
        public virtual TaiKhoan TaiKhoan { set; get; }

        [Required]
        public int MAKH { set; get; }

        [ForeignKey("MAKH")]
        public virtual KhachHang KhachHang { set; get; }

        public virtual IEnumerable<DonDatBan> DonDatBans { set; get; }
    }
}
