namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HANGHOA")]
    public partial class HANGHOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HANGHOA()
        {
            CTHOADONs = new HashSet<CTHOADON>();
        }

        [Key]
        [StringLength(10)]
        public string MaHH { get; set; }

        [Required]
        [StringLength(40)]
        public string TenHH { get; set; }

        [Required]
        [StringLength(30)]
        public string MauSac { get; set; }

        [Required]
        [StringLength(3)]
        public string Size { get; set; }

        [Column(TypeName = "money")]
        public decimal DonGiaNhap { get; set; }

        [Column(TypeName = "money")]
        public decimal DonGiaBan { get; set; }

        [Required]
        [StringLength(6)]
        public string DVT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHOADON> CTHOADONs { get; set; }

        public virtual KHO KHO { get; set; }
    }
}
