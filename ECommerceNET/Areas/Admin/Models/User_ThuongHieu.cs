using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceNET.Areas.Admin.Models
{
    public class User_ThuongHieu
    {
        public int idThuongHieu { get; set; }
       
        public string tenThuongHieu { get; set; }
       
        public string hinhLogo { get; set; }

        public string sdtThuongHieu { get; set; }
       
        public string emailThuongHieu { get; set; }

        public string trangThai { get; set; }

        public DateTime ngayTao { get; set; }

        public DateTime ngayCapNhat { get; set; }

        public string hoUser { get; set; }
        
        public string tenUser { get; set; }
    }
}
