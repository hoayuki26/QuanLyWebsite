namespace BTL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HDX")]
    public partial class HDX
    {
        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        public int? MaKH { get; set; }

        [StringLength(10)]
        public string MaSP { get; set; }

        public int? SL { get; set; }

        public DateTime? NgayBan { get; set; }

        public double? Tongtien { get; set; }
    }
}
