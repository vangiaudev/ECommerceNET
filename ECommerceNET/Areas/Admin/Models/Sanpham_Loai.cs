using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceNET.Areas.Admin.Models
{
    public class Sanpham_Loai
    {
        public int idSP { get; set; }
       
        public string tenSP { get; set; }

        public int giaSP { get; set; }



        public string hinhAnh { get; set; }


        public int luotXem { get; set; }

        public int soLuongKho { get; set; }


        public int luotMua { get; set; }
        public string moTa { get; set; }

        public string LoaiSP { get; set; }
        

        public string trangThai { get; set; }

        public DateTime ngayTao { get; set; }

        public DateTime ngayCapNhat { get; set; }




    }
}
