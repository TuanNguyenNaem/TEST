namespace Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyBanHang_DbContext : DbContext
    {
        public QuanLyBanHang_DbContext()
            : base("name=QuanLyBanHang_DbContext")
        {
        }

        public virtual DbSet<CTHOADON> CTHOADONs { get; set; }
        public virtual DbSet<HANGHOA> HANGHOAs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<KHACHHANGVIP> KHACHHANGVIPs { get; set; }
        public virtual DbSet<KHO> KHOes { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<TKNHANVIEN> TKNHANVIENs { get; set; }
        public virtual DbSet<VIP> VIPs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CTHOADON>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<CTHOADON>()
                .Property(e => e.MaHH)
                .IsUnicode(false);

            modelBuilder.Entity<CTHOADON>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HANGHOA>()
                .Property(e => e.MaHH)
                .IsUnicode(false);

            modelBuilder.Entity<HANGHOA>()
                .Property(e => e.Size)
                .IsUnicode(false);

            modelBuilder.Entity<HANGHOA>()
                .Property(e => e.DonGiaNhap)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HANGHOA>()
                .Property(e => e.DonGiaBan)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HANGHOA>()
                .Property(e => e.DVT)
                .IsUnicode(false);

            modelBuilder.Entity<HANGHOA>()
                .HasMany(e => e.CTHOADONs)
                .WithRequired(e => e.HANGHOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HANGHOA>()
                .HasOptional(e => e.KHO)
                .WithRequired(e => e.HANGHOA);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CTHOADONs)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.KHACHHANGVIPs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANGVIP>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANGVIP>()
                .Property(e => e.MaVIP)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANGVIP>()
                .Property(e => e.TichLuy)
                .HasPrecision(19, 4);

            modelBuilder.Entity<KHACHHANGVIP>()
                .Property(e => e.DVT)
                .IsUnicode(false);

            modelBuilder.Entity<KHO>()
                .Property(e => e.MaHH)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.TKNHANVIENs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TKNHANVIEN>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<TKNHANVIEN>()
                .Property(e => e.Account)
                .IsUnicode(false);

            modelBuilder.Entity<TKNHANVIEN>()
                .Property(e => e.Pass)
                .IsUnicode(false);

            modelBuilder.Entity<TKNHANVIEN>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<VIP>()
                .Property(e => e.MaVIP)
                .IsUnicode(false);

            modelBuilder.Entity<VIP>()
                .Property(e => e.MocTichLuy)
                .HasPrecision(19, 4);

            modelBuilder.Entity<VIP>()
                .Property(e => e.DVT)
                .IsUnicode(false);

            modelBuilder.Entity<VIP>()
                .HasMany(e => e.KHACHHANGVIPs)
                .WithRequired(e => e.VIP)
                .WillCascadeOnDelete(false);
        }
    }
}
