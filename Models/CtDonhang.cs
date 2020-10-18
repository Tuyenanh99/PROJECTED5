using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJECTED5.Models
{
    [Table("CT_Donhang")]
    public partial class CtDonhang
    {
        [Key]
        [Column("Ma_CT")]
        public int MaCt { get; set; }
        public int? Madon { get; set; }
        public int? Masp { get; set; }
        [StringLength(255)]
        public string Tensp { get; set; }
        public string Images { get; set; }
        public int? Soluong { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Dongia { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Thanhtien { get; set; }

        [ForeignKey(nameof(Madon))]
        [InverseProperty(nameof(Donhang.CtDonhang))]
        public virtual Donhang MadonNavigation { get; set; }
        [ForeignKey(nameof(Masp))]
        [InverseProperty(nameof(Sanpham.CtDonhang))]
        public virtual Sanpham MaspNavigation { get; set; }
    }
}
