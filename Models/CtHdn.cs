using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJECTED5.Models
{
    [Table("CT_hdn")]
    public partial class CtHdn
    {
        [Key]
        [Column("ma_ct_hdn")]
        public int MaCtHdn { get; set; }
        [Column("ma_don_nhap")]
        public int? MaDonNhap { get; set; }
        public int? Masp { get; set; }
        [Column("maloai")]
        public int? Maloai { get; set; }
        [Column("so_luong")]
        public int? SoLuong { get; set; }
        [Column("don_gia", TypeName = "decimal(18, 0)")]
        public decimal? DonGia { get; set; }

        [ForeignKey(nameof(MaDonNhap))]
        [InverseProperty(nameof(HoaDonNhap.CtHdn))]
        public virtual HoaDonNhap MaDonNhapNavigation { get; set; }
    }
}
