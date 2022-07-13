using ECommerceNET.Models;
using ECommerceNET.Session;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceNET.Controllers
{
    public class GioiThieuController : Controller
    {
        public sessionuser ssuser
        {
            get
            {
                var data = HttpContext.Session.Get<sessionuser>("ssuser");
                /* if (data == null)
                  {
                      data = new sessionuser();
                  }*/
                return data;
            }
        }

        public IActionResult Index()
        {
            if (ssuser != null)
            {
                ViewBag.houser = ssuser.hoUser;
                ViewBag.tenuser = ssuser.tenUser;
                ViewBag.accmenu1 = "Thông tin cá nhân";
                ViewBag.accmenu2 = "Đơn mua";
                ViewBag.accmenu3 = "Thoát";
                if (ssuser.vaitro == "admin")
                {
                    ViewBag.accmenu4 = "Trang quản trị";
                }
                else if (ssuser.vaitro == "staff")
                {
                    ViewBag.accmenu4 = "Trang nhân viên";
                }
            }
            else
            {
                ViewBag.houser = "TÀI";
                ViewBag.tenuser = "KHOẢN";
                ViewBag.accmenu1 = "Đăng nhập";
            }
            ViewBag.tieude = "GIỚI THIỆU VỀ YAN";
            ViewBag.noidung = "Công ty thời trang YAN được thành lập từ tháng 01 năm 2022";

            ViewBag.cau1 = "Người đại diện: Nguyễn Văn Giàu";
            ViewBag.cau2 = "YAN là một trong những thương hiệu thời trang nam dành cho giới trẻ uy tín hàng đầu Việt Nam. Với sự quản lý chặt chẽ, chuyên nghiệp của đội ngủ quản lý; Nỗ lực sáng tạo không ngừng của bộ phận thiết kế, Sự tận tâm chuyên nghiệp của nhân viên bán hàng… là những yếu tố làm nên thương hiệu thời trang YAN lớn mạnh như hiện nay.";

            ViewBag.cau3 = "YAN luôn quan niệm thời trang là sự tìm tòi và sáng tạo nên những sản phẩm của Chúng tôi đều được thiết kế riêng với sự trẻ trung, hiện đại, cá tính để mang lại guu thời trang hợp mốt nhất, cập nhật các xu hướng hot nhất cho các bạn trẻ. Các dòng sản phẩm của YAN không ngừng đa dạng về kiểu dáng, màu sắc và mẫu mã từ áo sơ mi, áo thun, bộ đồ đôi, áo khoác, quần jean, quần tây, quần kaki… đến các phụ kiện thời trang vô cùng sành điệu như balo, kính, giày dép…, tất cả tạo nên vẻ đẹp hoàn hảo, trẻ trung, hiện đại, phong cách thành thị cho phái mạnh.";

            ViewBag.cau4 = "Bên cạnh đó YAN luôn đặt mình vào tâm thế và quyền lợi của khách hàng để đưa ra những dòng sản phẩm thời trang chất lượng tốt, mẫu mã cực đẹp đón các đầu xu hướng thời trang, mới lạ cá tính nhưng với giá cả cực kì hấp dẫn, cạnh tranh nhất.";

            ViewBag.cau5 = "Hiện nay, thương hiệu thời trang nam YAN phát triển ngày càng lớn mạnh thành một hệ thống với nhiều chi nhánh cửa hàng bán lẻ tại Hà Nội. Ngoài ra, nhằm tạo sự tiện lợi mua sắm tối đa cho khách hàng, YAN phát triển hệ thống bán hàng online qua website; và fanpag: là Fanpage chính thức của nhãn hàng, chúng tôi giao hàng đến tận tay người tiêu dung trên toàn quốc.Giờ đây ngay tại nhà bạn cũng có thể chọn cho mình những sản phẩm phù hợp với sở thích và phong cách";

            ViewBag.cau6 = "Đến với YAN, chúng tôi luôn tận tâm tư vấn giúp quý khách tìm được những sản phẩm yêu thích, phù hợp với nhu cầu và góp phần tạo nên phong cách cho riêng mình!";
            return View();
        }
    }
}
