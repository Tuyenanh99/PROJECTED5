using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJECTED5.Models
{
    [Table("loaisp")]
    public partial class Loaisp
    {
        public Loaisp()
        {
            Sanpham = new HashSet<Sanpham>();
        }

        [Key]
        [Column("maloai")]
        public int Maloai { get; set; }
        [Column("tenloai")]
        [StringLength(50)]
        public string Tenloai { get; set; }
        [Column("mota")]
        public string Mota { get; set; }

        [InverseProperty("MaloaiNavigation")]
        public virtual ICollection<Sanpham> Sanpham { get; set; }
    }
}
