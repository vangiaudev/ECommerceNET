
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceNET.Entities
{
    [Table("Banner")]
    public class Banner
    {
        [Key]
        public int idBanner { get; set; }
      
        public string hinhAnh { get; set; }
        
        public DateTime ngayTao { get; set; }
        [Required]
        public DateTime ngayBatDau { get; set; }
        [Required]
        public DateTime ngayKetThuc { get; set; }
        [MaxLength(5000)]
        public string url { get; set; }

      

    }
}
