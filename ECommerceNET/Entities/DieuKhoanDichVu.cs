using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ECommerceNET.Entities
{
    [Table("DieuKhoanDichVu")]
    public class DieuKhoanDichVu
    {
        [Key]
        public int idDieuKhoanDV { get; set; }
     
        public string tieuDe { get; set; }
        public string noiDung { get; set; }
        public string hinhAnh { get; set; }
        public DateTime ngayTao { get; set; }
        public DateTime ngayCapNhat { get; set; }
        
    }
}
