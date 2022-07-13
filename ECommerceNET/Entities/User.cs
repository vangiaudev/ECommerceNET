using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceNET.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        public int idUser { get; set; }
        [Required]
        [MaxLength(10)]
        public string hoUser { get; set; }
        [Required]
        [MaxLength(50)]
        public string tenUser { get; set; }
        [Required]
        [MaxLength(10)]
        public string sdtUser { get; set; }
        [Required]
        [MaxLength(200)]
        [EmailAddress(ErrorMessage = "Nhập đúng định dạng email!")]
        public string emailUser { get; set; }
        [Required]
        public string matKhau { get; set; }

        public int gioiTinh { get; set; }

        public DateTime ngaySinh { get; set; }

        public string diaChi { get; set; }

        public string hinhAVT { get; set; }

        public DateTime ngayTao { get; set; }

        public DateTime ngayCapNhat { get; set; }

        public DateTime hoatDongLanCuoi { get; set; }

        public string trangThai { get; set; }

        public string vaiTro { get; set; }

        public ICollection<Banner> Banners { get; set; }

        public ICollection<ThuongHieu> ThuongHieus { get; set; }

        public ICollection<LoaiSP> LoaiSPs { get; set; }

        public ICollection<SanPham> SanPhams { get; set; }

        public ICollection<MaGiamGia> MaGiamGias { get; set; }




        public ICollection<DonHang> DonHangs { get; set; }


  





        public ICollection<GioiThieu> GioiThieus  { get; set; }

      
        public ICollection<DieuKhoanDichVu> DieuKhoanDichVus { get; set; }
       
        public ICollection<QuyDinhChung> QuyDinhChungs { get; set; }
        public ICollection<ChinhSachGiaoHang> ChinhSachGiaoHangs { get; set; }
   
        public ICollection<GioHang> GioHangs { get; set; }
        public ICollection<IPuser> IPusers { get; set; }
        public User()
        {
            Banners = new HashSet<Banner>();
            ThuongHieus = new HashSet<ThuongHieu>();
            LoaiSPs = new HashSet<LoaiSP>();
            SanPhams = new HashSet<SanPham>();
            MaGiamGias = new HashSet<MaGiamGia>();

      
            DonHangs = new HashSet<DonHang>();

     
     

       
            GioiThieus = new HashSet<GioiThieu>();
         
            DieuKhoanDichVus = new HashSet<DieuKhoanDichVu>();
            
            QuyDinhChungs = new HashSet<QuyDinhChung>();
            ChinhSachGiaoHangs = new HashSet<ChinhSachGiaoHang>();
         
            GioHangs = new HashSet<GioHang>();
            IPusers = new HashSet<IPuser>();
        }
    }
}
