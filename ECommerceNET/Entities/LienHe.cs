using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceNET.Entities
{
    [Table("LienHe")]
    public class LienHe
    {
        [Key]
        public int idLH { get; set; }
        [Required]
        [MaxLength(50)]
        public string hoTen { get; set; }
        [Required]
        [MaxLength(200)]
        [EmailAddress(ErrorMessage = "Nhập đúng định dạng email!")]
        public string eMail { get; set; }
        [Required]
        public string tieuDe { get; set; }
        [Required]
        public string noiDung { get; set; }

        public DateTime ngayGui { get; set; }

        public DateTime ngayCapNhat { get; set; }

        public string trangThai { get; set; }
    }
}
