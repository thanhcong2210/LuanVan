using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhaHangTC.Model.Models
{
    [Table("NHANVIEN")]
    public class NhanVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MANV { set; get; }

        [Required]
        [MaxLength(100)]
        public string HOTEN_NV { set; get; }

        [Required]
        [MaxLength(10)]
        public string SDT_NV { set; get; }

        [Required]
        [MaxLength(200)]
        public string DIACHI_NV { set; get; }

        [Required]
        [MaxLength(200)]
        public string EMAIL_NV { set; get; }

        [Required]
        public DateTime NGAYSINH_NV { set; get; }

        [Required]
        public bool GIOITINH_NV { set; get; }

        [Required]
        public int MANHAHANG { set; get; }

        [ForeignKey("MANHAHANG")]
        public virtual NhaHang NhaHang { set; get; }

        [Required]
        public int MACV { set; get; }

        [ForeignKey("MACV")]
        public virtual ChucVu ChucVu { set; get; }

        public virtual IEnumerable<NhanVien> NhanViens { set; get; }


    }
}
