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
    public class DoiMatKhau : Controller
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

                return RedirectToAction("index", "Home");
            }
            else
            {
                ViewBag.houser = "TÀI";
                ViewBag.tenuser = "KHOẢN";
                ViewBag.accmenu1 = "Đăng nhập";
            }
            return View();

        }


        private readonly MyDBContext _context;

        public DoiMatKhau(MyDBContext context)
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


        public sessionuser tamp
        {
            get
            {
                var data = HttpContext.Session.Get<sessionuser>("tamp");
                /* if (data == null)
                  {
                      data = new sessionuser();
                  }*/
                return data;
            }
        }

        public sessionuser xoatamp
        {
            get
            {
                var data = HttpContext.Session.Get<sessionuser>("tamp");
                if (data == null)
                {
                    data = new sessionuser();
                }
                return data;
            }
        }

        public Models.MaXacNhan mxn
        {
            get
            {
                var data = HttpContext.Session.Get<Models.MaXacNhan>("mxns");
                /* if (data == null)
                  {
                      data = new sessionuser();
                  }*/
                return data;
            }
        }

        public Models.MaXacNhan xoass
        {
            get
            {
                var data = HttpContext.Session.Get<Models.MaXacNhan>("mxns");
                if (data != null)
                {
                    data = null;
                }
                return data;

            }

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
        public async Task<IActionResult> LuuMatKhau(string qmk)
        {


            User item = _context.Users
                .FirstOrDefault(p => p.idUser == tamp.idUser);

            item.matKhau = GetMD5(qmk).ToUpper();


            _context.Update(item);
            await _context.SaveChangesAsync();




            sessionuser xx = tamp;

            HttpContext.Session.Set("ssuser", xx);

            sessionuser xxx = xoatamp;


            HttpContext.Session.Set("tamp", xxx);



            Models.MaXacNhan session = xoass;
            HttpContext.Session.Set("mxns", session);



            return View();
        }
    }
}
