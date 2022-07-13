using ECommerceNET.Entities;
using ECommerceNET.Models;
using ECommerceNET.Session;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceNET.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DonHangsController : Controller
    {
        private readonly MyDBContext _context;

        public DonHangsController(MyDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (ssuser == null)
            {

                return RedirectToAction("outadmin", "homeadmin");
            }
            else if (ssuser.vaitro != "admin")
            {
                return RedirectToAction("outadmin", "homeadmin");
            }
            ViewBag.tenadmin = ssuser.hoUser + " " + ssuser.tenUser;
            return View(_context.DonHangs.OrderByDescending(p=>p.idDH));
        }

        public IActionResult Details(int? id)
        {
            if (ssuser == null)
            {

                return RedirectToAction("outadmin", "homeadmin");
            }
            else if (ssuser.vaitro != "admin")
            {
                return RedirectToAction("outadmin", "homeadmin");
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

            var itemm = _context.ChiTietDonHangs.Where(p => p.idDH == id);


            return View(itemm);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (ssuser == null)
            {

                return RedirectToAction("outadmin", "homeadmin");
            }
            else if (ssuser.vaitro != "admin")
            {
                return RedirectToAction("outadmin", "homeadmin");
            }
            if (id == null)
            {
                return NotFound();
            }

            var loaispx = await _context.DonHangs.FindAsync(id);
     

            if (loaispx == null)
            {
                return NotFound();
            }
            return View(loaispx);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, DonHang loai)
        {
            if (id != loai.idDH)
            {
                return NotFound();
            }

            var loaix = _context.DonHangs
                .FirstOrDefault(p => p.idDH == id);

            if (ModelState.IsValid)
            {
                loaix.tenDH = loai.tenDH;
                loaix.hoDH = loai.hoDH;
                loaix.sdtDH = loai.sdtDH;
                loaix.eMail = loai.eMail;
                loaix.diaChi = loai.diaChi;
                loaix.ghiChu = loai.ghiChu;
                loaix.ngayCapNhat = DateTime.Now;

                loaix.trangThai = loai.trangThai;
                    _context.Update(loaix);
                    await _context.SaveChangesAsync();
             
                





                return RedirectToAction(nameof(Index));
            }
            return View(loai);
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
        public IActionResult TimAjax(string keyword)
        {

            if (!string.IsNullOrEmpty(keyword))
            {
                
                return PartialView(_context.DonHangs.OrderByDescending(p => p.idDH).Where(p=>p.tenDH.Contains(keyword) || p.hoDH.Contains(keyword) || p.idDH.ToString()==keyword || p.eMail.Contains(keyword) ||p.sdtDH==keyword));

            }

           


            return PartialView(_context.DonHangs.OrderByDescending(p => p.idDH));
        }

    }
}
