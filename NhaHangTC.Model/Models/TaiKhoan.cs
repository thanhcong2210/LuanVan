using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhaHangTC.Model.Models
{


    [Table("TAIKHOAN")]
    public class TaiKhoan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MATAIKHOAN { set; get; }

        [Required]
        [MaxLength(20)]
        public string TENDANGNHAP { set; get; }

        [Required]
        [MaxLength(50)]
        public string MATKHAU { set; get; }

        [Required]
        [MaxLength(10)]
        public string QUYENSD { set; get; }

        [Required]
        public bool TRANGTHAIKICHHOAT { set; get; }

        [Required]
        public int MANV { set; get; }

        [ForeignKey("MANV")]
        public virtual NhanVien NhanVien { set; get; }

        public virtual IEnumerable<TaiKhoan> TaiKhoans { set; get; }
    }
}
