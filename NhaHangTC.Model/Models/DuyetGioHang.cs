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
        [MaxLength(50)]
        public string NGAYDUYET { set; get; }

        [Required]
        [MaxLength(50)]
        public string TRANGTHAIDUYET { set; get; }

        public virtual IEnumerable<DuyetGioHang> DuyetGioHangs { set; get; }
    }
}
