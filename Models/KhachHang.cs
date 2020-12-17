namespace BTL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaKH { get; set; }

        [Required]
        [StringLength(50)]
        public string Hoten { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? SDT { get; set; }

        public string DiaChi { get; set; }
    }
}
