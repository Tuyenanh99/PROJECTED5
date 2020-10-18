using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJECTED5.Models
{
    [Table("tin_tuc")]
    public partial class TinTuc
    {
        [Key]
        [Column("ma_tin")]
        public int MaTin { get; set; }
        [Column("tieude")]
        public string Tieude { get; set; }
        [Column("hinhanh")]
        public string Hinhanh { get; set; }
        [Column("noidung")]
        public string Noidung { get; set; }
    }
}
