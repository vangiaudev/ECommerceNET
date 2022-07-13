

using Microsoft.EntityFrameworkCore;

namespace ECommerceNET.Entities
{
    public class MyDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }


        public DbSet<Banner> Banners { get; set; }
        public DbSet<ChinhSachGiaoHang> ChinhSachGiaoHangs { get; set; }


      
        public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }



        public DbSet<DieuKhoanDichVu> DieuKhoanDichVus { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<GioiThieu> GioiThieus { get; set; }

        public DbSet<IPuser> IPusers { get; set; }
        public DbSet<LienHe> LienHes { get; set; }
        public DbSet<LoaiSP> LoaiSPs { get; set; }

      
        public DbSet<MaGiamGia> MaGiamGias { get; set; }
 
       
        public DbSet<QuyDinhChung> QuyDinhChungs { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }

        public DbSet<ThuongHieu> ThuongHieus { get; set; }

        public DbSet<DSEmail> dSEmails { get; set; }
   
        public object User { get; internal set; }

        public MyDBContext(DbContextOptions options) : base(options) { }
    }
}
