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
    public class UserController : Controller
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
                return RedirectToAction("index", "login");
            }

            var ds = _context.Users
                .Where(p => p.idUser == ssuser.idUser);

            return View(ds);
        }

        private readonly MyDBContext _context;

        public UserController(MyDBContext context)
        {
            _context = context;
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
        public IActionResult hoatdong()
        {
            if (ssuser!=null)
            {
                var x = _context.Users.FirstOrDefault(p => p.idUser == ssuser.idUser);

                x.hoatDongLanCuoi = DateTime.Now;

                _context.Update(x);
                _context.SaveChanges();

            }
            return View();
        }

        [HttpPost]
        public async  Task<IActionResult> TTin(string ho, string ten, string email, string sdt, string dchi)
        {
            var ds = _context.Users
                .FirstOrDefault(p => p.idUser == ssuser.idUser);
            ds.hoUser = ho;
            ds.tenUser = ten;
            ds.emailUser = email;
            ds.sdtUser = sdt;
            ds.diaChi = dchi;

            _context.Update(ds);
            await _context.SaveChangesAsync();
            ViewBag.mess = "Cập nhật thành công!";
            return View();
        }

  
        private String GetMD5(string txt)
        {
            String str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }

        [HttpPost]
        public async Task<IActionResult> Mkhau(string pw, string newpw)
        {
            var ds = _context.Users
                .FirstOrDefault(p => p.idUser == ssuser.idUser);
            pw = GetMD5(pw).ToLower();
            if (ds.matKhau != pw)
            {
                ViewBag.mess = pw; 
                    //"Mật khẩu không đúng!";
                return View();
            }
            ds.matKhau = GetMD5(newpw).ToLower();

            _context.Update(ds);
            await _context.SaveChangesAsync();
            ViewBag.mess = "Cập nhật thành công!";
            return View();
        }


    }
}
