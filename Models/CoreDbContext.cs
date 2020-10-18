using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PROJECTED5.Models
{
    public partial class CoreDbContext : DbContext
    {
        public CoreDbContext()
        {
        }

        public CoreDbContext(DbContextOptions<CoreDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CtDonhang> CtDonhang { get; set; }
        public virtual DbSet<CtHdn> CtHdn { get; set; }
        public virtual DbSet<Donhang> Donhang { get; set; }
        public virtual DbSet<HoaDonNhap> HoaDonNhap { get; set; }
        public virtual DbSet<Khachang> Khachang { get; set; }
        public virtual DbSet<Loaisp> Loaisp { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCap { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<Sanpham> Sanpham { get; set; }
        public virtual DbSet<TinTuc> TinTuc { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=ADMIN\\CONGTUYEN;Database=DA5;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CtDonhang>(entity =>
            {
                entity.HasOne(d => d.MadonNavigation)
                    .WithMany(p => p.CtDonhang)
                    .HasForeignKey(d => d.Madon)
                    .HasConstraintName("FK_CT_Donhang_donhang");

                entity.HasOne(d => d.MaspNavigation)
                    .WithMany(p => p.CtDonhang)
                    .HasForeignKey(d => d.Masp)
                    .HasConstraintName("FK_CT_Donhang_sanpham");
            });

            modelBuilder.Entity<CtHdn>(entity =>
            {
                entity.HasOne(d => d.MaDonNhapNavigation)
                    .WithMany(p => p.CtHdn)
                    .HasForeignKey(d => d.MaDonNhap)
                    .HasConstraintName("FK_CT_hdn_Hoa_don_nhap1");
            });

            modelBuilder.Entity<Donhang>(entity =>
            {
                entity.HasOne(d => d.MakhNavigation)
                    .WithMany(p => p.Donhang)
                    .HasForeignKey(d => d.Makh)
                    .HasConstraintName("FK_donhang_khachang");
            });

            modelBuilder.Entity<HoaDonNhap>(entity =>
            {
                entity.Property(e => e.TongTien).IsFixedLength();

                entity.HasOne(d => d.MaNccNavigation)
                    .WithMany(p => p.HoaDonNhap)
                    .HasForeignKey(d => d.MaNcc)
                    .HasConstraintName("FK_Hoa_don_nhap_nha_cung_cap");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.HoaDonNhap)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK_Hoa_don_nhap_nhan_vien");
            });

            modelBuilder.Entity<Khachang>(entity =>
            {
                entity.Property(e => e.EmailKh).IsUnicode(false);

                entity.Property(e => e.Matkhau).IsUnicode(false);

                entity.Property(e => e.PhoneKh).IsUnicode(false);

                entity.Property(e => e.Taikhoan).IsUnicode(false);
            });

            modelBuilder.Entity<NhaCungCap>(entity =>
            {
                entity.Property(e => e.PhoneNcc).IsFixedLength();
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.Property(e => e.PhoneNv).IsUnicode(false);
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasOne(d => d.MaloaiNavigation)
                    .WithMany(p => p.Sanpham)
                    .HasForeignKey(d => d.Maloai)
                    .HasConstraintName("FK_sanpham_loaisp");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.MatKhau).IsUnicode(false);

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK_User_nhan_vien");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
