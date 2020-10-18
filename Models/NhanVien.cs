using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJECTED5.Models
{
    [Table("nhan_vien")]
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDonNhap = new HashSet<HoaDonNhap>();
            User = new HashSet<User>();
        }

        [Key]
        [Column("ma_nv")]
        public int MaNv { get; set; }
        [Column("ten_nv")]
        [StringLength(50)]
        public string TenNv { get; set; }
        [Column("chuc_vu")]
        [StringLength(50)]
        public string ChucVu { get; set; }
        [Column("email_nv")]
        [StringLength(50)]
        public string EmailNv { get; set; }
        [Column("dia_chi")]
        public string DiaChi { get; set; }
        [Column("phone_nv")]
        [StringLength(11)]
        public string PhoneNv { get; set; }

        [InverseProperty("MaNvNavigation")]
        public virtual ICollection<HoaDonNhap> HoaDonNhap { get; set; }
        [InverseProperty("MaNvNavigation")]
        public virtual ICollection<User> User { get; set; }
    }
}
