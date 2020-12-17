namespace BTL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatHang")]
    public partial class DatHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDH { get; set; }

        public int? MaKH { get; set; }

        [StringLength(50)]
        public string Hoten { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? Sdt { get; set; }

        public string Diachi { get; set; }

        public DateTime? NgayDat { get; set; }

        public double? Tongtien { get; set; }
    }
}
