using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhaHangTC.Model.Models
{
    [Table("KHACHHANG")]
    public class KhachHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MAKH { set; get; }

        [Required]
        [MaxLength(50)]
        public string HOTEN_KH { set; get; }

        [Required]
        [MaxLength(100)]
        public string DIACHI_KH { set; get; }

        [Required]
        [MaxLength(100)]
        public string EMAIL_KH { set; get; }

        [Required]
        [MaxLength(50)]
        public string SDT_KH { set; get; }

        [Required]
        [MaxLength(50)]
        public DateTime NAMSINH_KH { set; get; }

        [Required]
        [MaxLength(50)]
        public bool GIOITINH_KH { set; get; }

        [MaxLength(50)]
        public string TAIKHOAN_KH { set; get; }
 
        [MaxLength(50)]
        public string MATKHAU_KH { set; get; }

        [Required]
        public int MALOAI_KH { set; get; }

        [ForeignKey("MALOAI_KH")]
        public virtual LoaiKhachHang LoaiKhachHang { set; get; }

        [Required]
        public int MADATBAN { set; get; }

        [ForeignKey("MADATBAN")]
        public virtual DonDatBan DonDatBan { set; get; }


        public virtual IEnumerable<KhachHang> KhachHangs { set; get; }
    }
}
