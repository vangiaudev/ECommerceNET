

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceNET.Entities
{
    [Table("MaGiamGia")]
    public class MaGiamGia
    {
        [Key]
        public string codeMGG { get; set; }
        
        public string tenMGG { get; set; }
        
        public int giaTri { get; set; }
        
      
        
        public int soLuong { get; set; }
        [Required]
        public string trangThai { get; set; }
        
        public DateTime ngayTao { get; set; }

        public DateTime ngayCapNhat { get; set; }
        

        public ICollection<DonHang> DonHangs { get; set; }

        public MaGiamGia()
        {
            DonHangs = new HashSet<DonHang>();
        }
    }
}
