using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJECTED5.Models
{
    [Table("khachang")]
    public partial class Khachang
    {
        public Khachang()
        {
            Donhang = new HashSet<Donhang>();
        }

        [Key]
        [Column("ma_kh")]
        public int MaKh { get; set; }
        [Column("taikhoan")]
        [StringLength(50)]
        public string Taikhoan { get; set; }
        [Column("matkhau")]
        [StringLength(20)]
        public string Matkhau { get; set; }
        [Column("ten_kh")]
        [StringLength(50)]
        public string TenKh { get; set; }
        [Column("email_kh")]
        [StringLength(50)]
        public string EmailKh { get; set; }
        [Column("diachi_kh")]
        public string DiachiKh { get; set; }
        [Column("phone_kh")]
        [StringLength(11)]
        public string PhoneKh { get; set; }

        [InverseProperty("MakhNavigation")]
        public virtual ICollection<Donhang> Donhang { get; set; }
    }
}
