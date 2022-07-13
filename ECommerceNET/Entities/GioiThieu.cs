using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceNET.Entities
{
    [Table("GioiThieu")]
    public class GioiThieu
    {
        [Key]
        public int idGioiThieu { get; set; }
       
        public string tieuDe { get; set; }
        public string noiDung { get; set; }
        public int hinhAnh { get; set; }
        public DateTime ngayTao { get; set; }
        public DateTime ngayCapNhat { get; set; }
       
    }
}
