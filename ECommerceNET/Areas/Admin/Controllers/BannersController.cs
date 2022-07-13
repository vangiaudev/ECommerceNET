
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
    public class BannersController : Controller
    {

        private readonly MyDBContext _context;

        public BannersController(MyDBContext context)
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
            ViewBag.tenadmin = ssuser.hoUser +" " +ssuser.tenUser;
            return View(_context.Banners);
        }


        [HttpPost]
        public IActionResult TimAjax(string keyword)
        {
            var dsusers = _context.Banners.AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                dsusers = dsusers.Where(p => p.url.Contains(keyword));

                //   return PartialView(dsLoai);

            }

            var data = dsusers.Select(p => new Banner
            {

                idBanner=p.idBanner,
                hinhAnh=p.hinhAnh,
                ngayBatDau=p.ngayBatDau,
                ngayKetThuc=p.ngayKetThuc,
                ngayTao=p.ngayTao,
                url=p.url,
            });





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
        public async Task<IActionResult> Create(Banner user, IFormFile hinhAnh)
        {
            if (ModelState.IsValid)
            {
                if (hinhAnh != null)
                {
                    // DateTime hientai = DateTime.UtcNow;
                    // string htai = hientai.ToLongDateString();

                    string format = "yyyy_MM_dd_HH_mm_ss";

                    DateTime now = DateTime.Now;

                    string s = now.ToString(format) + ".jpg";

                    var urlfull = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "banner", s);
                    using (var file = new FileStream(urlfull, FileMode.Create))
                    {
                        await hinhAnh.CopyToAsync(file);
                    }

                    user.hinhAnh = s;

                }
                else
                {
                    user.hinhAnh = "def.jpg";
                }
                
                user.ngayTao = DateTime.Now;
                
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

            var loaispx = await _context.Banners.FindAsync(id);
        


            if (loaispx == null)
            {
                return NotFound();
            }
            return View(loaispx);
        }


        private bool BannersExists(int id)
        {
            return _context.Banners.Any(e => e.idBanner == id);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Banner user, IFormFile hinhAnh)
        {
            if (id != user.idBanner)
            {
                return NotFound();
            }

            var xx = _context.Banners
                .FirstOrDefault(p => p.idBanner == id);


            try
            {
                if (hinhAnh == null)
                {
                    xx.ngayBatDau = user.ngayBatDau;
                    xx.ngayKetThuc = user.ngayKetThuc;
                    xx.url = user.url;
                     

                }
                else
                {

                    
                    string format = "yyyy_MM_dd_HH_mm_ss";

                    DateTime now = DateTime.Now;

                    string s = now.ToString(format) + ".jpg";

                    var urlfull = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "banner", s);
                    using (var file = new FileStream(urlfull, FileMode.Create))
                    {
                        await hinhAnh.CopyToAsync(file);
                    }

                    xx.hinhAnh = s;
                    xx.url = user.url;
                    xx.ngayBatDau = user.ngayBatDau;
                    xx.ngayKetThuc = user.ngayKetThuc;


                }



                _context.Update(xx);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BannersExists(user.idBanner))

                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }







            return View(user);
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
            var xx = _context.Banners
                .FirstOrDefault(p => p.idBanner == id);

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
            var loai = await _context.Banners.FindAsync(id);
            //_context.Loais.Remove(loai);
            _context.Remove(loai);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //GET Loais/Details/5

        public IActionResult Details(int? id)
        {
            if (ssuser.vaitro != "admin" || ssuser==null)
            {
                return RedirectToAction("index", "login");
            }
            if (id == null)
            {
                return NotFound();
            }
            /*
            var loai = await _context.LoaiSPs
                .FirstOrDefaultAsync(m => m.idLoaiSP == id);
            */


            var xx = _context.Banners
                .FirstOrDefault(p => p.idBanner == id);




            if (xx == null)
            {
                return NotFound();
            }

            return View(xx);
        }



    }
}
