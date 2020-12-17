namespace BTL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatHangDetail")]
    public partial class DatHangDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCTDH { get; set; }

        public int MaDH { get; set; }

        [Required]
        [StringLength(10)]
        public string MaSP { get; set; }

        [StringLength(50)]
        public string TenSP { get; set; }

        [StringLength(50)]
        public string Anh { get; set; }

        public int? SoLuong { get; set; }

        public int? Gia { get; set; }

        public double? Giamgia { get; set; }

        public double? Tongtien { get; set; }
    }
}
