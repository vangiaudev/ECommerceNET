
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ECommerceNET.Entities
{
    [Table ("ChiTietDonHang")]
    public class ChiTietDonHang
    {
        [Key]
        public int idCTDH { get; set; }
        
        public int idDH { get; set; }
        [ForeignKey("idDH")]
        public DonHang DonHang { get; set; }

        public string tenSP { get; set; }

 
        
        public string hinhSP { get; set; }

        public int donGia { get; set; }

        public int thanhTien { get; set; }

        public int soLuong { get; set; }

    }
}
