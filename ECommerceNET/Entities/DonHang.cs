

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceNET.Entities
{
    [Table("DonHang")]
    public class DonHang
    {
        [Key]
        public int idDH { get; set; }

        public DateTime ngayDat { get; set; }

        public DateTime ngayCapNhat { get; set; }
        [Required]
        [MaxLength(10)]
        public string hoDH { get; set; }
        [Required]
        [MaxLength(50)]
        public string tenDH { get; set; }
        [Required]
        [MaxLength(200)]
        public string diaChi { get; set; }
        [Required]
        [MaxLength(200)]
        [EmailAddress(ErrorMessage = "Nhập đúng định dạng email!")]
        public string eMail { get; set; }
        [Required]
        [MaxLength(10)]
        public string sdtDH { get; set; }

       
        public string ghiChu { get; set; }

        public int tongTienHang { get; set; }

        public int maGiamGiaDH { get; set; }
        
 


        public int tongSoTien { get; set; }

        public string trangThai { get; set; }

        public int idUser { get; set; }
       
        
        public ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }



        public DonHang()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();

        }
    }
}
