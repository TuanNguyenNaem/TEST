namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VIP")]
    public partial class VIP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VIP()
        {
            KHACHHANGVIPs = new HashSet<KHACHHANGVIP>();
        }

        [Key]
        [StringLength(10)]
        public string MaVIP { get; set; }

        [Column(TypeName = "money")]
        public decimal MocTichLuy { get; set; }

        public byte GiamHoaDon { get; set; }

        [Required]
        [StringLength(6)]
        public string DVT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHACHHANGVIP> KHACHHANGVIPs { get; set; }
    }
}
