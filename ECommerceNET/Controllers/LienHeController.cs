using ECommerceNET.Entities;
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
    public class LienHeController : Controller
    {
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
            return View();
        }
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

        [HttpPost]
        public  IActionResult IndexAdd(string hoten, string email, string tieude, string noidung)

        {

            LienHe lh = new LienHe();

            lh.ngayGui = DateTime.Now;
            lh.trangThai = "Đang xử lý";
            lh.ngayCapNhat = DateTime.Now;
            lh.hoTen = hoten;
            lh.eMail = email;
            lh.tieuDe = tieude;
            lh.noiDung = noidung;

            _context.Add(lh);
            _context.SaveChanges();
            return View();
        }


        private readonly MyDBContext _context;

        public LienHeController(MyDBContext context)
        {
            _context = context;
        }
    }
}
