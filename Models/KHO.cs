namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHO")]
    public partial class KHO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int STT { get; set; }

        [Key]
        [StringLength(10)]
        public string MaHH { get; set; }

        public int SoLuongTon { get; set; }

        public virtual HANGHOA HANGHOA { get; set; }
    }
}
