using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhaHangTC.Model.Models
{

    [Table("GIOHANG")]
    public class GioHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MAGH { set; get; }

        [Required]
        public int MAKH { set; get; }

        [ForeignKey("MAKH")]
        public virtual KhachHang KhachHang { set; get; }

        [Required]
        public DateTime NGAYDAT { set; get; }

        [Required]
        public bool TRANGTHAI { set; get; }

        [Required]
        [MaxLength(350)]
        public string DIACHINHAN { set; get; }

        public virtual IEnumerable<GioHang> GioHangs { set; get; }
    }
}
