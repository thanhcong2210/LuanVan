﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhaHangTC.Model.Models
{

    [Table("HINHANH")]
    public class HinhAnh
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MAHINHANH { set; get; }

        [Required]
        [MaxLength(350)]
        public string DUONGDAN1 { set; get; }

        [Required]
        [MaxLength(350)]
        public string DUONGDAN2 { set; get; }

        [Required]
        [MaxLength(350)]
        public string DUONGDAN3 { set; get; }

        public virtual IEnumerable<HinhAnh> HinhAnhs { set; get; }
    }
}
