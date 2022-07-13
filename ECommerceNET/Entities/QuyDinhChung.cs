using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceNET.Entities
{
    [Table("QuyDinhChung")]
    public class QuyDinhChung
    {
        [Key]
        public int idQuyDinhChung { get; set; }
  
        public string tieuDe { get; set; }
        public string noiDung { get; set; }
        public string hinhAnh { get; set; }
        public DateTime ngayTao { get; set; }
        public DateTime ngayCapNhat { get; set; }

    }
}
