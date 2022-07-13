using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceNET.Models
{
    public class SSGioHang
    {
        public int idSP { get; set; }
        
        public string tensp { get; set; }
        public int giasp { get; set; }

        public string hinhAnh { get; set; }
        public int soLuong { get; set; }
        public int thanhTien => soLuong * giasp;
    }
}
