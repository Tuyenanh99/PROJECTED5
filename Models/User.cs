using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJECTED5.Models
{
    public partial class User
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("ten_tk")]
        [StringLength(50)]
        public string TenTk { get; set; }
        [Column("mat_khau")]
        [StringLength(20)]
        public string MatKhau { get; set; }
        [Column("ma_nv")]
        public int? MaNv { get; set; }
        [Column("ten_nv")]
        [StringLength(50)]
        public string TenNv { get; set; }
        [Column("chuc_vu")]
        [StringLength(50)]
        public string ChucVu { get; set; }

        [ForeignKey(nameof(MaNv))]
        [InverseProperty(nameof(NhanVien.User))]
        public virtual NhanVien MaNvNavigation { get; set; }
    }
}
