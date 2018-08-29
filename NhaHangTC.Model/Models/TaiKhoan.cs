using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;

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

        //public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<TaiKhoan> manager, string authenticationType)
        //{
        //    // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
        //    var taikhoanIdentity = await manager.CreateIdentityAsync(this, authenticationType);
        //    // Add custom user claims here
        //    return taikhoanIdentity;
        //}
        public virtual IEnumerable<TaiKhoan> TaiKhoans { set; get; }
    }
}
