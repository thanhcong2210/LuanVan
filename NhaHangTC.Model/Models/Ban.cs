using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhaHangTC.Model.Models
{
    [Table("BAN")]
    public class Ban
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MABAN { set; get; }


        [MaxLength(20)]
        public string TENTANG { set; get; }


        public bool TRANGTHAIBAN { set; get; }

        [Required]
        public int MATANG { set; get; }

        [ForeignKey("MATANG")]
        public virtual Tang Tang { set; get; }

    }
}
