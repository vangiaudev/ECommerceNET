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
    public class MaGiamGiasController : Controller
    {

        private readonly MyDBContext _context;

        public MaGiamGiasController(MyDBContext context)
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
            return View(_context.MaGiamGias.OrderByDescending(p=>p.ngayTao));
        }

        [HttpPost]
        public IActionResult TimAjax(string keyword)
        {
            var dsusers = _context.MaGiamGias.AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                dsusers = dsusers.Where(p => p.codeMGG.Contains(keyword) || p.tenMGG.Contains(keyword) );

                //   return PartialView(dsLoai);

            }

            var data = dsusers.Select(p => new MaGiamGia
            {

                codeMGG = p.codeMGG,
                tenMGG=p.tenMGG,
                giaTri=p.giaTri,
                soLuong=p.soLuong,
                trangThai=p.trangThai,
                ngayCapNhat=p.ngayCapNhat,
                ngayTao=p.ngayTao,
            }) ;





            return PartialView(data);
        }


        // GET: Loais/Create
        public IActionResult Create()
        {
            if (ssuser == null)
            {

                return RedirectToAction("outadmin", "homeadmin");
            }
            else if (ssuser.vaitro != "admin")
            {
                return RedirectToAction("outadmin", "homeadmin");
            }
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MaGiamGia user)
        {
            if (ModelState.IsValid)
            {
               
               
                
                user.ngayTao = DateTime.Now;
                user.ngayCapNhat = DateTime.Now;
                
                _context.Add(user);
                await _context.SaveChangesAsync();
                //   return RedirectToAction(nameof(Index));

            }
            return RedirectToAction("Index");

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
        public async Task<IActionResult> Edit(string id)
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

            var loaispx = await _context.MaGiamGias.FindAsync(id);
       

            if (loaispx == null)
            {
                return NotFound();
            }
            return View(loaispx);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, MaGiamGia user)
        {
            if (id != user.codeMGG)
            {
                return NotFound();
            }

            var xx = _context.MaGiamGias
                .FirstOrDefault(p => p.codeMGG == id);

            xx.trangThai = user.trangThai;

            xx.codeMGG = user.codeMGG;
            xx.tenMGG = user.tenMGG;
            xx.soLuong = user.soLuong;
            xx.giaTri = user.giaTri;

                    xx.ngayCapNhat = DateTime.Now;

               

                _context.Update(xx);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));


        }




        // GET: Loais/Delete/5
        public IActionResult Delete(string id)
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
            var xx = _context.MaGiamGias
                .FirstOrDefault(p => p.codeMGG == id);

            if (xx == null)
            {
                return NotFound();
            }

            return View(xx);
        }

        // POST: Loais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var loai = await _context.MaGiamGias.FindAsync(id);
            //_context.Loais.Remove(loai);
            _context.Remove(loai);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        //GET Loais/Details/5

        public IActionResult Details(string id)
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


            var xx = _context.MaGiamGias
                .FirstOrDefault(p => p.codeMGG == id);




            if (xx == null)
            {
                return NotFound();
            }

            return View(xx);
        }



    }
}
