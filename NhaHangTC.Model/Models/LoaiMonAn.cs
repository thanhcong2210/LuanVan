using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhaHangTC.Model.Models
{
    [Table("LOAIMONAN")]
    public class Ban
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MALOAI { set; get; }

        [Required]
        [MaxLength(20)]
        public string TENLOAI { set; get; }

        public virtual IEnumerable<Ban> LoaiMonAns { set; get; }
    }
}
