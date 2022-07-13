using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceNET.Entities
{
    [Table("SanPham")]
    public class SanPham
    {
       
        [Key]
        public int idSP { get; set; }
        [Required]
        [MaxLength(100)]
        public string tenSP { get; set; }

        public int giaSP { get; set; }

     
       
        public string hinhAnh { get; set; }
       

        public int luotXem { get; set; }
        
        public int soLuongKho { get; set; }
    
        
        public int luotMua { get; set; }
        public string moTa { get; set; }

        public int idLoaiSP { get; set; }
        [ForeignKey("idLoaiSP")]
        public LoaiSP LoaiSP { get; set; }


        public string trangThai { get; set; }

        public DateTime ngayTao { get; set; }

        public DateTime ngayCapNhat { get; set; }
       




   


        public ICollection<GioHang> GioHangs { get; set; }
        public SanPham()
        {
 

  
   
         
            GioHangs = new HashSet<GioHang>();
        }
    }
}
