using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhaHangTC.Model.Models
{

    [Table("CHITIETHOADON")]
    public class ChiTietHoaDon
    {
        [Key]
        [Column(Order = 1)]
        public int MAHD { set; get; }

        [Key]
        [Column(Order = 2)]
        public int MAMON { set; get; }

        public int SOLUONG { set; get; }


        [ForeignKey("MAHD")]
        public virtual HoaDon HoaDon { set; get; }

        [ForeignKey("MAMON")]
        public virtual MonAn MonAn { set; get; }
    }
}
