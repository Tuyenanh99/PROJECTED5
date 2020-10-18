using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJECTED5.Models
{
    [Table("nha_cung_cap")]
    public partial class NhaCungCap
    {
        public NhaCungCap()
        {
            HoaDonNhap = new HashSet<HoaDonNhap>();
        }

        [Key]
        [Column("ma_ncc")]
        public int MaNcc { get; set; }
        [Column("maloai")]
        public int? Maloai { get; set; }
        [Column("masp")]
        public int? Masp { get; set; }
        [Column("tensp")]
        [StringLength(100)]
        public string Tensp { get; set; }
        [Column("ten_ncc")]
        [StringLength(100)]
        public string TenNcc { get; set; }
        [Column("diachi_ncc")]
        public string DiachiNcc { get; set; }
        [Column("email_ncc")]
        [StringLength(100)]
        public string EmailNcc { get; set; }
        [Column("phone_ncc")]
        [StringLength(10)]
        public string PhoneNcc { get; set; }

        [InverseProperty("MaNccNavigation")]
        public virtual ICollection<HoaDonNhap> HoaDonNhap { get; set; }
    }
}
