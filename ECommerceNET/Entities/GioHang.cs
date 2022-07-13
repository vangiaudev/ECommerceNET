using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceNET.Entities
{
    [Table("GioHang")]
    public class GioHang
    {
        [Key]
        public int idGioHang { get; set; }

        public int idsp { get; set; }

        public int tensp { get; set; }

        public int giasp { get; set; }

        public int soLuong { get; set; }
       
        public int idUser { get; set; }
        [ForeignKey("idUser")]
        public User User { get; set; }

        public int thanhTien => soLuong * giasp;
    }
}
