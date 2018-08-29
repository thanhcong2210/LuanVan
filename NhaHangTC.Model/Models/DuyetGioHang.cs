using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhaHangTC.Model.Models
{

    [Table("DUYETGIOHANG")]
    public class DuyetGioHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MADUYET { set; get; }

        [Required]
        public int MATAIKHOAN { set; get; }

        [ForeignKey("MATAIKHOAN")]
        public virtual TaiKhoan TaiKhoan { set; get; }

        [Required]
        public int MAGH { set; get; }

        [ForeignKey("MAGH")]
        public virtual GioHang GioHang { set; get; }

        [Required]

        public DateTime NGAYDUYET { set; get; }

        [Required]
        public bool TRANGTHAIDUYET { set; get; }

        public virtual IEnumerable<DuyetGioHang> DuyetGioHangs { set; get; }
    }
}
