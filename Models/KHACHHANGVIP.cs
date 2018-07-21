namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANGVIP")]
    public partial class KHACHHANGVIP
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int STT { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaKH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaVIP { get; set; }

        [Column(TypeName = "money")]
        public decimal TichLuy { get; set; }

        [Required]
        [StringLength(6)]
        public string DVT { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual VIP VIP { get; set; }
    }
}
