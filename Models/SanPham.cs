namespace BTL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        [StringLength(10)]
        public string MaSP { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSP { get; set; }

        public string Mota { get; set; }

        public int? SL { get; set; }

        public int Dongia { get; set; }

        [Required]
        [StringLength(10)]
        public string MaLoai { get; set; }

        [StringLength(50)]
        public string Anh { get; set; }
    }
}
