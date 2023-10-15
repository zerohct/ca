using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DoAnLTWin_QuanLyPhongKhamNhaKhoa.Model1;

public partial class DaphongkhamnhakhoaContext : DbContext
{
    public DaphongkhamnhakhoaContext()
    {
    }

    public DaphongkhamnhakhoaContext(DbContextOptions<DaphongkhamnhakhoaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Benhnhan> Benhnhans { get; set; }

    public virtual DbSet<Chucvu> Chucvus { get; set; }

    public virtual DbSet<Ctdt> Ctdts { get; set; }

    public virtual DbSet<Cthd> Cthds { get; set; }

    public virtual DbSet<Ctk> Ctks { get; set; }

    public virtual DbSet<Ctpdt> Ctpdts { get; set; }

    public virtual DbSet<Ctpdtb> Ctpdtbs { get; set; }

    public virtual DbSet<Ctpgt> Ctpgts { get; set; }

    public virtual DbSet<Ctpgtb> Ctpgtbs { get; set; }

    public virtual DbSet<Ctpkdt> Ctpkdts { get; set; }

    public virtual DbSet<Ctpkk> Ctpkks { get; set; }

    public virtual DbSet<Ctpktb> Ctpktbs { get; set; }

    public virtual DbSet<Dangthuoc> Dangthuocs { get; set; }

    public virtual DbSet<Dichvu> Dichvus { get; set; }

    public virtual DbSet<Donthuoc> Donthuocs { get; set; }

    public virtual DbSet<Hoadon> Hoadons { get; set; }

    public virtual DbSet<Kho> Khos { get; set; }

    public virtual DbSet<Luong> Luongs { get; set; }

    public virtual DbSet<Nhacungcap> Nhacungcaps { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Phieudathang> Phieudathangs { get; set; }

    public virtual DbSet<Phieudieutri> Phieudieutris { get; set; }

    public virtual DbSet<Phieugiaohang> Phieugiaohangs { get; set; }

    public virtual DbSet<Phieuhen> Phieuhens { get; set; }

    public virtual DbSet<Phieukiem> Phieukiems { get; set; }

    public virtual DbSet<Phieuluong> Phieuluongs { get; set; }

    public virtual DbSet<Taikhoan> Taikhoans { get; set; }

    public virtual DbSet<Thietbi> Thietbis { get; set; }

    public virtual DbSet<Thuoc> Thuocs { get; set; }

    public virtual DbSet<ViewChucVu> ViewChucVus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-77K2FI5\\SQLEXPRESS;Initial Catalog=DAPHONGKHAMNHAKHOA;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Benhnhan>(entity =>
        {
            entity.HasKey(e => e.MaBn).HasName("PK__BENHNHAN__272475ADA89DE572");

            entity.ToTable("BENHNHAN");

            entity.Property(e => e.MaBn).HasColumnName("MaBN");
            entity.Property(e => e.DiaChi).HasColumnType("ntext");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .HasColumnName("EMAIL");
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(10)
                .UseCollation("Vietnamese_CI_AI");
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenBn)
                .HasMaxLength(30)
                .HasColumnName("TenBN");
        });

        modelBuilder.Entity<Chucvu>(entity =>
        {
            entity.HasKey(e => e.MaCv).HasName("PK__CHUCVU__27258E7620A19122");

            entity.ToTable("CHUCVU");

            entity.Property(e => e.MaCv).HasColumnName("MaCV");
            entity.Property(e => e.Mota)
                .HasColumnType("ntext")
                .HasColumnName("MOTA");
            entity.Property(e => e.TenCv)
                .HasMaxLength(30)
                .HasColumnName("TenCV");
        });

        modelBuilder.Entity<Ctdt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CTDT");

            entity.Property(e => e.Cachdung)
                .HasColumnType("ntext")
                .HasColumnName("CACHDUNG");
            entity.Property(e => e.Dongia)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DONGIA");
            entity.Property(e => e.Dvt)
                .HasMaxLength(20)
                .HasColumnName("DVT");
            entity.Property(e => e.MaDt).HasColumnName("MaDT");
            entity.Property(e => e.Sl).HasColumnName("SL");

            entity.HasOne(d => d.MaDtNavigation).WithMany()
                .HasForeignKey(d => d.MaDt)
                .HasConstraintName("FK__CTDT__MaDT__6754599E");

            entity.HasOne(d => d.MaThuocNavigation).WithMany()
                .HasForeignKey(d => d.MaThuoc)
                .HasConstraintName("FK__CTDT__MaThuoc__68487DD7");
        });

        modelBuilder.Entity<Cthd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CTHD");

            entity.Property(e => e.Dongia)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DONGIA");
            entity.Property(e => e.MaHd).HasColumnName("MaHD");
            entity.Property(e => e.Mapdt).HasColumnName("MAPDT");
            entity.Property(e => e.Trangthai)
                .HasColumnType("ntext")
                .HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MaHdNavigation).WithMany()
                .HasForeignKey(d => d.MaHd)
                .HasConstraintName("FK__CTHD__MaHD__71D1E811");

            entity.HasOne(d => d.MapdtNavigation).WithMany()
                .HasForeignKey(d => d.Mapdt)
                .HasConstraintName("FK__CTHD__MAPDT__72C60C4A");
        });

        modelBuilder.Entity<Ctk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CTK");

            entity.Property(e => e.MaKho).HasColumnName("MaKHO");
            entity.Property(e => e.Mathuoc).HasColumnName("MATHUOC");
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Trangthai)
                .HasMaxLength(20)
                .HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MaKhoNavigation).WithMany()
                .HasForeignKey(d => d.MaKho)
                .HasConstraintName("FK__CTK__MaKHO__74AE54BC");

            entity.HasOne(d => d.MathuocNavigation).WithMany()
                .HasForeignKey(d => d.Mathuoc)
                .HasConstraintName("FK__CTK__MATHUOC__75A278F5");
        });

        modelBuilder.Entity<Ctpdt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CTPDT");

            entity.Property(e => e.Gia)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("GIA");
            entity.Property(e => e.MaPdh).HasColumnName("MaPDH");
            entity.Property(e => e.Sl).HasColumnName("SL");

            entity.HasOne(d => d.MaPdhNavigation).WithMany()
                .HasForeignKey(d => d.MaPdh)
                .HasConstraintName("FK__CTPDT__MaPDH__4F7CD00D");

            entity.HasOne(d => d.MaThuocNavigation).WithMany()
                .HasForeignKey(d => d.MaThuoc)
                .HasConstraintName("FK__CTPDT__MaThuoc__5070F446");
        });

        modelBuilder.Entity<Ctpdtb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CTPDTB");

            entity.Property(e => e.Gia)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("GIA");
            entity.Property(e => e.MaPdh).HasColumnName("MaPDH");
            entity.Property(e => e.Matb).HasColumnName("MATB");
            entity.Property(e => e.Sl).HasColumnName("SL");

            entity.HasOne(d => d.MaPdhNavigation).WithMany()
                .HasForeignKey(d => d.MaPdh)
                .HasConstraintName("FK__CTPDTB__MaPDH__5812160E");

            entity.HasOne(d => d.MatbNavigation).WithMany()
                .HasForeignKey(d => d.Matb)
                .HasConstraintName("FK__CTPDTB__MATB__59063A47");
        });

        modelBuilder.Entity<Ctpgt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CTPGT");

            entity.Property(e => e.Gia)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("GIA");
            entity.Property(e => e.MaPgh).HasColumnName("MaPGH");
            entity.Property(e => e.Sl).HasColumnName("SL");

            entity.HasOne(d => d.MaPghNavigation).WithMany()
                .HasForeignKey(d => d.MaPgh)
                .HasConstraintName("FK__CTPGT__MaPGH__4CA06362");

            entity.HasOne(d => d.MaThuocNavigation).WithMany()
                .HasForeignKey(d => d.MaThuoc)
                .HasConstraintName("FK__CTPGT__MaThuoc__4D94879B");
        });

        modelBuilder.Entity<Ctpgtb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CTPGTB");

            entity.Property(e => e.Gia)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("GIA");
            entity.Property(e => e.MaPgh).HasColumnName("MaPGH");
            entity.Property(e => e.MaTb).HasColumnName("MaTB");
            entity.Property(e => e.Sl).HasColumnName("SL");

            entity.HasOne(d => d.MaPghNavigation).WithMany()
                .HasForeignKey(d => d.MaPgh)
                .HasConstraintName("FK__CTPGTB__MaPGH__5535A963");

            entity.HasOne(d => d.MaTbNavigation).WithMany()
                .HasForeignKey(d => d.MaTb)
                .HasConstraintName("FK__CTPGTB__MaTB__5629CD9C");
        });

        modelBuilder.Entity<Ctpkdt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CTPKDT");

            entity.Property(e => e.Dongia)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DONGIA");
            entity.Property(e => e.MaDv).HasColumnName("MaDV");
            entity.Property(e => e.MaPdt).HasColumnName("MaPDT");
            entity.Property(e => e.Sl).HasColumnName("SL");

            entity.HasOne(d => d.MaDvNavigation).WithMany()
                .HasForeignKey(d => d.MaDv)
                .HasConstraintName("FK__CTPKDT__MaDV__6B24EA82");

            entity.HasOne(d => d.MaPdtNavigation).WithMany()
                .HasForeignKey(d => d.MaPdt)
                .HasConstraintName("FK__CTPKDT__MaPDT__6A30C649");
        });

        modelBuilder.Entity<Ctpkk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CTPKK");

            entity.Property(e => e.MaPk).HasColumnName("MaPK");
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Trangthai)
                .HasMaxLength(20)
                .HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MaPkNavigation).WithMany()
                .HasForeignKey(d => d.MaPk)
                .HasConstraintName("FK__CTPKK__MaPK__52593CB8");

            entity.HasOne(d => d.MakhoNavigation).WithMany()
                .HasForeignKey(d => d.Makho)
                .HasConstraintName("FK__CTPKK__Makho__534D60F1");
        });

        modelBuilder.Entity<Ctpktb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CTPKTB");

            entity.Property(e => e.MaPk).HasColumnName("MaPK");
            entity.Property(e => e.Matb).HasColumnName("MATB");
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Trangthai)
                .HasColumnType("ntext")
                .HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MaPkNavigation).WithMany()
                .HasForeignKey(d => d.MaPk)
                .HasConstraintName("FK__CTPKTB__MaPK__5AEE82B9");

            entity.HasOne(d => d.MatbNavigation).WithMany()
                .HasForeignKey(d => d.Matb)
                .HasConstraintName("FK__CTPKTB__MATB__5BE2A6F2");
        });

        modelBuilder.Entity<Dangthuoc>(entity =>
        {
            entity.HasKey(e => e.MaDt).HasName("PK__DANGTHUO__272586559DE44517");

            entity.ToTable("DANGTHUOC");

            entity.Property(e => e.MaDt).HasColumnName("MaDT");
            entity.Property(e => e.TenDt)
                .HasMaxLength(20)
                .HasColumnName("TenDT");
        });

        modelBuilder.Entity<Dichvu>(entity =>
        {
            entity.HasKey(e => e.MaDv).HasName("PK__DICHVU__272586579368AFFA");

            entity.ToTable("DICHVU");

            entity.Property(e => e.MaDv).HasColumnName("MaDV");
            entity.Property(e => e.Dvt)
                .HasMaxLength(20)
                .HasColumnName("DVT");
            entity.Property(e => e.Giadv)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("GIADV");
            entity.Property(e => e.Khuyenmai).HasColumnName("KHUYENMAI");
            entity.Property(e => e.Sl)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SL");
            entity.Property(e => e.TenDv)
                .HasMaxLength(30)
                .HasColumnName("TenDV");
            entity.Property(e => e.Tgbh).HasColumnName("TGBH");
        });

        modelBuilder.Entity<Donthuoc>(entity =>
        {
            entity.HasKey(e => e.MaDt).HasName("PK__DONTHUOC__27258655C74B9C02");

            entity.ToTable("DONTHUOC");

            entity.Property(e => e.MaDt).HasColumnName("MaDT");
            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.MaPdt).HasColumnName("MaPDT");
            entity.Property(e => e.Ngaylap)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("NGAYLAP");
            entity.Property(e => e.Tongtien)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TONGTIEN");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.Donthuocs)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK__DONTHUOC__MaNV__6477ECF3");

            entity.HasOne(d => d.MaPdtNavigation).WithMany(p => p.Donthuocs)
                .HasForeignKey(d => d.MaPdt)
                .HasConstraintName("FK__DONTHUOC__MaPDT__656C112C");
        });

        modelBuilder.Entity<Hoadon>(entity =>
        {
            entity.HasKey(e => e.MaHd).HasName("PK__HOADON__2725A6E065EC78F1");

            entity.ToTable("HOADON");

            entity.Property(e => e.MaHd).HasColumnName("MaHD");
            entity.Property(e => e.MaBn).HasColumnName("MaBN");
            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.Ngaylap)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("NGAYLAP");
            entity.Property(e => e.Tongtien)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TONGTIEN");
            entity.Property(e => e.Trangthai)
                .HasColumnType("ntext")
                .HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MaBnNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.MaBn)
                .HasConstraintName("FK__HOADON__MaBN__6FE99F9F");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK__HOADON__MaNV__6EF57B66");
        });

        modelBuilder.Entity<Kho>(entity =>
        {
            entity.HasKey(e => e.MaKho).HasName("PK__KHO__3BD980E8D33719AD");

            entity.ToTable("KHO");

            entity.Property(e => e.MaKho).HasColumnName("MaKHO");
            entity.Property(e => e.ViTri).HasColumnType("ntext");
        });

        modelBuilder.Entity<Luong>(entity =>
        {
            entity.HasKey(e => e.MaLuong).HasName("PK__LUONG__94873021BDA90762");

            entity.ToTable("LUONG");

            entity.Property(e => e.MaLuong).HasColumnName("MaLUONG");
            entity.Property(e => e.MaCv).HasColumnName("MaCV");
            entity.Property(e => e.Tienluong)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TIENLUONG");

            entity.HasOne(d => d.MaCvNavigation).WithMany(p => p.Luongs)
                .HasForeignKey(d => d.MaCv)
                .HasConstraintName("FK__LUONG__MaCV__239E4DCF");
        });

        modelBuilder.Entity<Nhacungcap>(entity =>
        {
            entity.HasKey(e => e.MaNcc).HasName("PK__NHACUNGC__3A185DEBB644F763");

            entity.ToTable("NHACUNGCAP");

            entity.Property(e => e.MaNcc).HasColumnName("MaNCC");
            entity.Property(e => e.DiaChi).HasColumnType("ntext");
            entity.Property(e => e.Email)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenNcc)
                .HasMaxLength(30)
                .HasColumnName("TenNCC");
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.MaNv).HasName("PK__NHANVIEN__2725D70A3C76F900");

            entity.ToTable("NHANVIEN");

            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.DiaChi).HasColumnType("ntext");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Gt)
                .HasMaxLength(10)
                .UseCollation("Vietnamese_CI_AI")
                .HasColumnName("GT");
            entity.Property(e => e.MaCv).HasColumnName("MaCV");
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenNv)
                .HasMaxLength(30)
                .HasColumnName("TenNV");

            entity.HasOne(d => d.MaCvNavigation).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.MaCv)
                .HasConstraintName("FK__NHANVIEN__MaCV__1B0907CE");
        });

        modelBuilder.Entity<Phieudathang>(entity =>
        {
            entity.HasKey(e => e.MaPdh).HasName("PK__PHIEUDAT__3AE048C7BC10CFDE");

            entity.ToTable("PHIEUDATHANG");

            entity.Property(e => e.MaPdh).HasColumnName("MaPDH");
            entity.Property(e => e.MaNcc).HasColumnName("MaNCC");
            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.Ngaylap)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("NGAYLAP");
            entity.Property(e => e.Tongtien)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TONGTIEN");
            entity.Property(e => e.Trangthai)
                .HasColumnType("ntext")
                .HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MaNccNavigation).WithMany(p => p.Phieudathangs)
                .HasForeignKey(d => d.MaNcc)
                .HasConstraintName("FK__PHIEUDATH__MaNCC__2F10007B");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.Phieudathangs)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK__PHIEUDATHA__MaNV__2E1BDC42");
        });

        modelBuilder.Entity<Phieudieutri>(entity =>
        {
            entity.HasKey(e => e.MaPdt).HasName("PK__phieudie__3AE048CB94A1DC16");

            entity.ToTable("phieudieutri");

            entity.Property(e => e.MaPdt).HasColumnName("MaPDT");
            entity.Property(e => e.Chuandoan)
                .HasColumnType("ntext")
                .HasColumnName("CHUANDOAN");
            entity.Property(e => e.MaBn).HasColumnName("MaBN");
            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.Nddt)
                .HasColumnType("ntext")
                .HasColumnName("NDDT");
            entity.Property(e => e.Ngaylap)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("NGAYLAP");
            entity.Property(e => e.Tongtien)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TONGTIEN");

            entity.HasOne(d => d.MaBnNavigation).WithMany(p => p.Phieudieutris)
                .HasForeignKey(d => d.MaBn)
                .HasConstraintName("FK__phieudieut__MaBN__60A75C0F");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.Phieudieutris)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK__phieudieut__MaNV__5FB337D6");
        });

        modelBuilder.Entity<Phieugiaohang>(entity =>
        {
            entity.HasKey(e => e.MaPgh).HasName("PK__PHIEUGIA__3AE3DEBF4FBD532B");

            entity.ToTable("PHIEUGIAOHANG");

            entity.Property(e => e.MaPgh).HasColumnName("MaPGH");
            entity.Property(e => e.MaNcc).HasColumnName("MaNCC");
            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.MaPdh).HasColumnName("MaPDH");
            entity.Property(e => e.Ngaylap)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("NGAYLAP");
            entity.Property(e => e.Tongtien)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TONGTIEN");
            entity.Property(e => e.Trangthai)
                .HasColumnType("ntext")
                .HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MaNccNavigation).WithMany(p => p.Phieugiaohangs)
                .HasForeignKey(d => d.MaNcc)
                .HasConstraintName("FK__PHIEUGIAO__MaNCC__34C8D9D1");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.Phieugiaohangs)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK__PHIEUGIAOH__MaNV__32E0915F");

            entity.HasOne(d => d.MaPdhNavigation).WithMany(p => p.Phieugiaohangs)
                .HasForeignKey(d => d.MaPdh)
                .HasConstraintName("FK__PHIEUGIAO__MaPDH__33D4B598");
        });

        modelBuilder.Entity<Phieuhen>(entity =>
        {
            entity.HasKey(e => e.MaPh).HasName("PK__PHIEUHEN__2725E7FA5869D8B1");

            entity.ToTable("PHIEUHEN");

            entity.Property(e => e.MaPh).HasColumnName("MaPH");
            entity.Property(e => e.MaBn).HasColumnName("MaBN");
            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.Ngayhen)
                .HasColumnType("date")
                .HasColumnName("NGAYHEN");
            entity.Property(e => e.Ngaylap)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("NGAYLAP");
            entity.Property(e => e.Trangthai)
                .HasColumnType("ntext")
                .HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MaBnNavigation).WithMany(p => p.Phieuhens)
                .HasForeignKey(d => d.MaBn)
                .HasConstraintName("FK__PHIEUHEN__MaBN__403A8C7D");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.Phieuhens)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK__PHIEUHEN__MaNV__3F466844");
        });

        modelBuilder.Entity<Phieukiem>(entity =>
        {
            entity.HasKey(e => e.MaPk).HasName("PK__PHIEUKIE__2725E7FD010510F0");

            entity.ToTable("PHIEUKIEM");

            entity.Property(e => e.MaPk).HasColumnName("MaPK");
            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.Ngaylap)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("NGAYLAP");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.Phieukiems)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK__PHIEUKIEM__MaNV__4AB81AF0");
        });

        modelBuilder.Entity<Phieuluong>(entity =>
        {
            entity.HasKey(e => e.MaPl).HasName("PK__PHIEULUO__2725E7FE3436A612");

            entity.ToTable("PHIEULUONG");

            entity.Property(e => e.MaPl).HasColumnName("MaPL");
            entity.Property(e => e.MaLuong).HasColumnName("MaLUONG");
            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.Ngaylap)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("NGAYLAP");
            entity.Property(e => e.Tienthuong)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TIENTHUONG");
            entity.Property(e => e.Tientru)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TIENTRU");
            entity.Property(e => e.Trangthai)
                .HasColumnType("ntext")
                .HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MaLuongNavigation).WithMany(p => p.Phieuluongs)
                .HasForeignKey(d => d.MaLuong)
                .HasConstraintName("FK__PHIEULUON__MaLUO__2A4B4B5E");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.Phieuluongs)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK__PHIEULUONG__MaNV__29572725");
        });

        modelBuilder.Entity<Taikhoan>(entity =>
        {
            entity.HasKey(e => e.MaTk).HasName("PK__TAIKHOAN__27250070BB304FED");

            entity.ToTable("TAIKHOAN");

            entity.HasIndex(e => e.TenDangNhap, "UQ__TAIKHOAN__55F68FC0C7658099").IsUnique();

            entity.Property(e => e.MaTk).HasColumnName("MaTK");
            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TenDangNhap)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.Taikhoans)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK__TAIKHOAN__MaNV__20C1E124");
        });

        modelBuilder.Entity<Thietbi>(entity =>
        {
            entity.HasKey(e => e.MaTb).HasName("PK__thietbi__2725006F0CCD04A0");

            entity.ToTable("thietbi");

            entity.Property(e => e.MaTb).HasColumnName("MaTB");
            entity.Property(e => e.Mancc).HasColumnName("mancc");
            entity.Property(e => e.Sl)
                .HasDefaultValueSql("((0))")
                .HasColumnName("sl");
            entity.Property(e => e.TenTb)
                .HasMaxLength(30)
                .HasColumnName("TenTB");
            entity.Property(e => e.Tinhtrang)
                .HasColumnType("ntext")
                .HasColumnName("tinhtrang");

            entity.HasOne(d => d.ManccNavigation).WithMany(p => p.Thietbis)
                .HasForeignKey(d => d.Mancc)
                .HasConstraintName("FK__thietbi__mancc__46E78A0C");
        });

        modelBuilder.Entity<Thuoc>(entity =>
        {
            entity.HasKey(e => e.MaThuoc).HasName("PK__THUOC__4BB1F620CF8C50A3");

            entity.ToTable("THUOC");

            entity.Property(e => e.Gia)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("GIA");
            entity.Property(e => e.Hsd)
                .HasColumnType("date")
                .HasColumnName("HSD");
            entity.Property(e => e.MaDt).HasColumnName("MaDT");
            entity.Property(e => e.Mancc).HasColumnName("MANCC");
            entity.Property(e => e.Mota)
                .HasColumnType("ntext")
                .HasColumnName("MOTA");
            entity.Property(e => e.TenThuoc).HasMaxLength(30);

            entity.HasOne(d => d.MaDtNavigation).WithMany(p => p.Thuocs)
                .HasForeignKey(d => d.MaDt)
                .HasConstraintName("FK__THUOC__MaDT__398D8EEE");

            entity.HasOne(d => d.ManccNavigation).WithMany(p => p.Thuocs)
                .HasForeignKey(d => d.Mancc)
                .HasConstraintName("FK__THUOC__MANCC__3A81B327");
        });

        modelBuilder.Entity<ViewChucVu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewChucVu");

            entity.Property(e => e.MaCv).HasColumnName("MaCV");
            entity.Property(e => e.MoTa).HasColumnType("ntext");
            entity.Property(e => e.Tencv)
                .HasMaxLength(30)
                .HasColumnName("TENCV");
            entity.Property(e => e.TienLuong).HasColumnType("decimal(18, 0)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
