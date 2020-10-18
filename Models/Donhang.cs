using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJECTED5.Models
{
    [Table("donhang")]
    public partial class Donhang
    {
        public Donhang()
        {
            CtDonhang = new HashSet<CtDonhang>();
        }

        [Key]
        [Column("madon")]
        public int Madon { get; set; }
        [Column("makh")]
        public int? Makh { get; set; }
        [Column("tenkh")]
        [StringLength(50)]
        public string Tenkh { get; set; }
        [Column("diachi")]
        public string Diachi { get; set; }
        [Column("phone")]
        public int? Phone { get; set; }
        [Column("tongtien", TypeName = "decimal(18, 0)")]
        public decimal? Tongtien { get; set; }

        [ForeignKey(nameof(Makh))]
        [InverseProperty(nameof(Khachang.Donhang))]
        public virtual Khachang MakhNavigation { get; set; }
        [InverseProperty("MadonNavigation")]
        public virtual ICollection<CtDonhang> CtDonhang { get; set; }
    }
}
