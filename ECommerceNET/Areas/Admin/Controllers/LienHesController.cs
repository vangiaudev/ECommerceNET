using ECommerceNET.Entities;
using ECommerceNET.Models;
using ECommerceNET.Session;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceNET.Areas.Admin.Controllers
{
        [Area("Admin")]
    public class LienHesController : Controller
    {
       

        private readonly MyDBContext _context;

        public LienHesController(MyDBContext context)
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
            return View(_context.LienHes);
        }

        [HttpPost]
        public IActionResult TimAjax(string keyword)
        {
            var dsusers = _context.LienHes.AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                dsusers = dsusers.Where(p => p.tieuDe.Contains(keyword) || p.noiDung.Contains(keyword) || p.hoTen.Contains(keyword) || p.eMail.Contains(keyword));

                //   return PartialView(dsLoai);

            }

            var data = dsusers.Select(p => new LienHe
            {
                idLH = p.idLH,
                hoTen=p.hoTen,
                eMail=p.eMail,
                tieuDe=p.tieuDe,
                noiDung=p.noiDung,
                ngayCapNhat=p.ngayCapNhat,
                ngayGui=p.ngayGui,
                trangThai=p.trangThai
                
            });





            return PartialView(data);
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


        // GET: Loais/Edit/5
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

            var loaispx = await _context.LienHes.FindAsync(id);
           

            if (loaispx == null)
            {
                return NotFound();
            }
            return View(loaispx);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LienHe user)
        {
            if (id != user.idLH)
            {
                return NotFound();
            }

            var xx = _context.LienHes
                .FirstOrDefault(p => p.idLH == id);




            xx.trangThai = user.trangThai;

                    xx.ngayCapNhat = DateTime.Now;

              

                _context.Update(xx);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            
 
          
        }

        // GET: Loais/Delete/5
        public IActionResult Delete(int? id)
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

            /* var loai = await _context.LoaiSPs
                 .FirstOrDefaultAsync(m => m.idLoaiSP == id);*/
            var xx = _context.LienHes
                .FirstOrDefault(p => p.idLH == id);

            if (xx == null)
            {
                return NotFound();
            }

            return View(xx);
        }

        // POST: Loais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loai = await _context.LienHes.FindAsync(id);
            //_context.Loais.Remove(loai);
            _context.Remove(loai);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        //GET Loais/Details/5

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
            if (id == null)
            {
                return NotFound();
            }
            /*
            var loai = await _context.LoaiSPs
                .FirstOrDefaultAsync(m => m.idLoaiSP == id);
            */


            var xx = _context.LienHes
                .FirstOrDefault(p => p.idLH == id);




            if (xx == null)
            {
                return NotFound();
            }

            return View(xx);
        }


    }
}
