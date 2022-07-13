
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceNET.Entities
{
    [Table("ThuongHieu")]
    public class ThuongHieu
    {
        [Key]
        public int idThuongHieu { get; set; }
        [Required]
        [MaxLength(100)]
        public string tenThuongHieu { get; set; }
        [Required]
        public string hinhLogo { get; set; }
        
        public string sdtThuongHieu { get; set; }
        [Required]
        [MaxLength(200)]
        [EmailAddress(ErrorMessage = "Nhập đúng định dạng email!")]
        public string emailThuongHieu { get; set; }

        public string trangThai { get; set; }

        public DateTime ngayTao { get; set; }

        public DateTime ngayCapNhat { get; set; }
        public int idUser { get; set; }
        [ForeignKey("idUser")]
        public User User { get; set; }

        public ICollection<SanPham> SanPhams { get; set; }
        
        public ThuongHieu()
        {
            SanPhams = new HashSet<SanPham>();
        }
    }
}
