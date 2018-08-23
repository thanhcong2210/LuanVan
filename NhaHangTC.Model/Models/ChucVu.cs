using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhaHangTC.Model.Models
{
    [Table("CHUCVU")]
    public class ChucVu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MACV { set; get; }


        [MaxLength(20)]
        public string TENCV { set; get; }


        [MaxLength(100)]
        public string MOTACV { set; get; }

        public virtual IEnumerable<ChucVu> ChucVus { set; get; }
    }
}
