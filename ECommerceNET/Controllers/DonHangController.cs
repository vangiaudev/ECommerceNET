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
    public class DonHangController : Controller
    {
        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }


        private readonly MyDBContext _context;

        public DonHangController(MyDBContext context)
        {
            _context = context;
        }


        public IActionResult TraCuu(int id)
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
            var dh = _context.DonHangs.Where(p => p.idDH == id);

          

            return View(dh);
        }

        public IActionResult LichSuDonHang()
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


            if (ssuser == null)
            {
                return RedirectToAction("index", "login");
            }
            var dh = _context.DonHangs.Where(p=>p.idUser ==  ssuser.idUser);


            return View(dh);
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

        public IActionResult Chitietdonhang(int? id)
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
            if (ssuser == null)
            {
                return RedirectToAction("index", "login");
            }

            var dh = _context.DonHangs.FirstOrDefault(p => p.idDH == id);

            ViewBag.ngaydat = dh.ngayDat;
            ViewBag.hodh = dh.hoDH;
            ViewBag.tendh = dh.tenDH;
            ViewBag.diachi = dh.diaChi;
            ViewBag.email = dh.eMail;
            ViewBag.sdt = dh.sdtDH;
            ViewBag.ghichu = dh.ghiChu;
            ViewBag.tth = dh.tongTienHang;
            ViewBag.magg = dh.maGiamGiaDH;
            ViewBag.tongcong = dh.tongSoTien;
            ViewBag.trangthai = dh.trangThai;

            var itemm = _context.ChiTietDonHangs.Where(p => p.idDH==id);


            return View(itemm);
        }


    }
}
