using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceNET.Areas.Admin.Models
{
    
    public class User_Loai
    {
        public int idLoaiSP { get; set; }

        public string hinhAnh { get; set; }
        public string tenLoaiSP { get; set; }
        public int type { get; set; }
        public string metaTitle { get; set; }

        public string trangThai { get; set; }
        public DateTime ngayTao { get; set; }
        public DateTime ngayCapNhat { get; set; }
        public string hoUser { get; set; }
        public string tenUser { get; set; }
        public string typeLoai { get; set; }
    }
}
