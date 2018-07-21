namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TKNHANVIEN")]
    public partial class TKNHANVIEN
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int STT { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaNV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string Account { get; set; }

        [Required]
        [StringLength(15)]
        public string Pass { get; set; }

        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        [Required]
        [StringLength(30)]
        public string Role { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
