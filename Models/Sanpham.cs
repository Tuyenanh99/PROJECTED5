using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJECTED5.Models
{
    [Table("sanpham")]
    public partial class Sanpham
    {
        public Sanpham()
        {
            CtDonhang = new HashSet<CtDonhang>();
        }

        [Key]
        public int Masp { get; set; }
        [Column("maloai")]
        public int? Maloai { get; set; }
        [StringLength(100)]
        public string Tensp { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Dongia { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Ngaycapnhat { get; set; }
        public string Hinhanh { get; set; }
        [StringLength(50)]
        public string Baohanh { get; set; }
        public string Mota { get; set; }
        public int? Soluong { get; set; }
        public int? Luotbinhluan { get; set; }

        [ForeignKey(nameof(Maloai))]
        [InverseProperty(nameof(Loaisp.Sanpham))]
        public virtual Loaisp MaloaiNavigation { get; set; }
        [InverseProperty("MaspNavigation")]
        public virtual ICollection<CtDonhang> CtDonhang { get; set; }
    }
}
