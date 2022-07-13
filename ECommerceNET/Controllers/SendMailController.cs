using ECommerceNET.Entities;
using ECommerceNET.MailMessenger;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceNET.Models;
using Microsoft.AspNetCore.Http;
using ECommerceNET.Session;

namespace ECommerceNET.Controllers
{
 
    public class SendMailController :Controller
    {
        private readonly IEmailSender _emailsender;
        private readonly MyDBContext _context;
       
        public SendMailController(IEmailSender emailSender, MyDBContext context)
        {
            _emailsender = emailSender;
            _context = context;
        }

        [HttpPost]
        public IActionResult addmail(string? id)
        {
            var dsAcc = _context.dSEmails
                .SingleOrDefault(acc => (acc.diachiemail==id));
            if (dsAcc == null)
            {
                DSEmail ds = new DSEmail();
                ds.diachiemail = id;
                _context.Add(ds);
                _context.SaveChanges();
            }
            
            return View();
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

        [Obsolete]
        public IActionResult Index()
        {

            if (mxn==null)
            {
                return RedirectToAction("index", "Home");
            }
            

            var message = new Message(new string[] {mxn.emails}, "[YAN Store] Mã xác nhận tài khoản", "Đây là mã xác nhận của bạn: " + mxn.code);
            _emailsender.SendEmail(message);
         
            if (mxn.type == "0")
            {
                ViewBag.type = "0";
                ViewBag.tieude = "Mã xác nhận đã được gửi về email của bạn. Vui lòng nhập mã xác nhận:";
            }
            else if (mxn.type == "1")
            {
                ViewBag.tieude = "Chúng tôi phát hiện bạn đăng nhập từ trình duyệt lạ, do đó chúng tôi đã gửi mã xác nhận về email của bạn. Vui lòng nhập mã xác nhận:";
                ViewBag.type = "1";
            }
            else
            {
                ViewBag.tieude = "Mã xác nhận đã được gửi về email của bạn. Vui lòng nhập mã xác nhận:";
                ViewBag.type = "2";
            }
            return View();
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

        [HttpPost]
        [Obsolete]
        public IActionResult Donhangthanhcong(string id, string emails)
        {


            var message = new Message(new string[] { emails }, "[YAN Store] Đặt hàng thành công", "Đơn hàng của bạn đang được xử lý, bạn có thể dùng mã này để tra cứu trạng thái đơn hàng: " + id);
            _emailsender.SendEmail(message);

            return View();
        }




    }

}
