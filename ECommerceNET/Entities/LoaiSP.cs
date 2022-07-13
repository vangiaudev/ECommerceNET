using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ECommerceNET.Entities
{
    [Table("LoaiSP")]
    public class LoaiSP
    {
        [Key]
        public int idLoaiSP { get; set; }
        [Required]
        [MaxLength(50)]
        public string tenLoaiSP { get; set; }
       
        public string hinhAnh { get; set; }
        [Required]
        public string metaTitle { get; set; }
        
 
        public string typeLoai { get; set; }
        public string trangThai { get; set; }

        public DateTime ngayTao { get; set; }

        public DateTime ngayCapNhat { get; set; }
        public int idUser { get; set; }
        [ForeignKey("idUser")]
        public User User { get; set; }

        


    }
}
