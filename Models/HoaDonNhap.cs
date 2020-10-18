using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJECTED5.Models
{
    [Table("Hoa_don_nhap")]
    public partial class HoaDonNhap
    {
        public HoaDonNhap()
        {
            CtHdn = new HashSet<CtHdn>();
        }

        [Key]
        [Column("ma_don_nhap")]
        public int MaDonNhap { get; set; }
        [Column("ma_nv")]
        public int? MaNv { get; set; }
        [Column("ma_ncc")]
        public int? MaNcc { get; set; }
        [Column("ngay_nhap", TypeName = "date")]
        public DateTime? NgayNhap { get; set; }
        [Column("tong_tien")]
        [StringLength(10)]
        public string TongTien { get; set; }

        [ForeignKey(nameof(MaNcc))]
        [InverseProperty(nameof(NhaCungCap.HoaDonNhap))]
        public virtual NhaCungCap MaNccNavigation { get; set; }
        [ForeignKey(nameof(MaNv))]
        [InverseProperty(nameof(NhanVien.HoaDonNhap))]
        public virtual NhanVien MaNvNavigation { get; set; }
        [InverseProperty("MaDonNhapNavigation")]
        public virtual ICollection<CtHdn> CtHdn { get; set; }
    }
}
