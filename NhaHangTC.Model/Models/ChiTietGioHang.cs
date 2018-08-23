using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhaHangTC.Model.Models
{

    [Table("OrderDetails")]
    public class ChiTietGioHang
    {
        [Key]
        [Column(Order = 1)]
        public int MAMON { set; get; }

        [Key]
        [Column(Order = 2)]
        public int MAGH { set; get; }

        public int SLUONG { set; get; }

        [ForeignKey("MAMON")]
        public virtual MonAn MonAn { set; get; }

        [ForeignKey("MAGD")]
        public virtual GioHang GioHang { set; get; }
    }
}
