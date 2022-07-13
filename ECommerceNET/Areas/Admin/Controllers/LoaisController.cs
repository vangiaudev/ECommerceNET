using ECommerceNET.Entities;
using Microsoft.AspNetCore.Mvc;

using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using ECommerceNET.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Globalization;
using System.IO;
using ECommerceNET.Models;
using ECommerceNET.Session;

namespace ECommerceNET.Controllers
{
    [Area("Admin")]
    public class LoaisController : Controller
    {
      /*  public IActionResult Index()
        {
            return View();
        }*/
        private readonly MyDBContext _context;

        public LoaisController (MyDBContext context)
        {
            _context = context;
        }


        //GET Loais
        public IActionResult Index()
        {
            if ( ssuser == null)
            {

                return RedirectToAction("outadmin", "homeadmin");
            }
            else if (ssuser.vaitro != "admin")
            {
                return RedirectToAction("outadmin", "homeadmin");
            }
            ViewBag.tenadmin = ssuser.hoUser + " " + ssuser.tenUser;
            var loaisp
                = from p in _context.LoaiSPs
                  join c in _context.Users on p.idUser equals c.idUser
                  // where p.ProductId == 2
                  select new User_Loai
                  {
                      idLoaiSP = p.idLoaiSP,
                      hinhAnh = p.hinhAnh,
                 tenLoaiSP = p.tenLoaiSP,
                typeLoai=p.typeLoai,
                 metaTitle = p.metaTitle,
                 trangThai = p.trangThai,
                 ngayTao = p.ngayTao,
                 ngayCapNhat = p.ngayCapNhat,
                 hoUser =c.hoUser,
                 tenUser = c.tenUser
                  };

            
            return View(loaisp);
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


            var loaispx
                = from p in _context.LoaiSPs
                  join c in _context.Users on p.idUser equals c.idUser
                  where p.idLoaiSP == id
                  select new User_Loai
                  {
                      idLoaiSP = p.idLoaiSP,
                      hinhAnh = p.hinhAnh,
                      tenLoaiSP = p.tenLoaiSP,
                      typeLoai=p.typeLoai,
                      metaTitle = p.metaTitle,
                      trangThai = p.trangThai,
                      ngayTao = p.ngayTao,
                      ngayCapNhat = p.ngayCapNhat,
                      hoUser = c.hoUser,
                      tenUser = c.tenUser
                  };




            if (loaispx == null)
            {
                return NotFound();
            }

            return View(loaispx);
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

        // POST: Loais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LoaiSP loai, IFormFile hinhAnh)
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
                    
                    var urlfull = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot","images","loaisp",s);
                    using (var file = new FileStream(urlfull, FileMode.Create))
                    {
                        await hinhAnh.CopyToAsync(file);
                    }

                     loai.hinhAnh = s;
                }

                loai.idUser = ssuser.idUser;

               
                loai.ngayTao = DateTime.Now;
                loai.ngayCapNhat = DateTime.Now;
                _context.Add(loai);
                await _context.SaveChangesAsync();
             //   return RedirectToAction(nameof(Index));

            }
            return RedirectToAction("Index");
            
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

            var loaispx = await _context.LoaiSPs.FindAsync(id);
/*
            var loaispx
              = from p in _context.LoaiSPs
                join c in _context.Users on p.idUser equals c.idUser
                where p.idLoaiSP == id
                select new User_Loai
                {
                    idLoaiSP = p.idLoaiSP,
                    hinhAnh = p.hinhAnh,
                    tenLoaiSP = p.tenLoaiSP,

                    metaTitle = p.metaTitle,
                    trangThai = p.trangThai,
                    ngayTao = p.ngayTao,
                    ngayCapNhat = p.ngayCapNhat,
                    hoUser = c.hoUser,
                    tenUser = c.tenUser
                };
*/


            if (loaispx == null)
            {
                return NotFound();
            }
            return View(loaispx);
        }

        // POST: Loais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LoaiSP loai, IFormFile hinhAnh)
        {
            if (id != loai.idLoaiSP)
            {
                return NotFound();
            }

            var loaix = _context.LoaiSPs
                .FirstOrDefault(p => p.idLoaiSP == id);

            if (ModelState.IsValid)
            {
                try
                {
                    if (hinhAnh == null)
                    {
                        loaix.tenLoaiSP = loai.tenLoaiSP;

                        loaix.metaTitle = loai.metaTitle;

                        loaix.trangThai = loai.trangThai;

                        loaix.typeLoai = loai.typeLoai;



                        loaix.ngayCapNhat = DateTime.Now;

                    }
                    else
                    {
                        loaix.tenLoaiSP = loai.tenLoaiSP;
                        loaix.typeLoai = loai.typeLoai;

                        loaix.metaTitle = loai.metaTitle;

                        loaix.trangThai = loai.trangThai;

                        loaix.ngayCapNhat = DateTime.Now;

                        string format = "yyyy_MM_dd_HH_mm_ss";

                        DateTime now = DateTime.Now;

                        string s = now.ToString(format) + ".jpg";

                        var urlfull = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "loaisp", s);
                        using (var file = new FileStream(urlfull, FileMode.Create))
                        {
                            await hinhAnh.CopyToAsync(file);
                        }

                        loaix.hinhAnh = s;



                    }



                    _context.Update(loaix);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                   if (!LoaiSPExists(loai.idLoaiSP))
                  
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }




                
                return RedirectToAction(nameof(Index));
            }
            return View(loai);
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
            var loaispx
                 = from p in _context.LoaiSPs
                   join c in _context.Users on p.idUser equals c.idUser
                   where p.idLoaiSP == id
                   select new User_Loai
                   {
                       idLoaiSP = p.idLoaiSP,
                       hinhAnh = p.hinhAnh,
                       tenLoaiSP = p.tenLoaiSP,
                       typeLoai = p.typeLoai,
                       metaTitle = p.metaTitle,
                       trangThai = p.trangThai,
                       ngayTao = p.ngayTao,
                       ngayCapNhat = p.ngayCapNhat,
                       hoUser = c.hoUser,
                       tenUser = c.tenUser
                   };

            if (loaispx == null)
            {
                return NotFound();
            }

            return View(loaispx);
        }

        // POST: Loais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loai = await _context.LoaiSPs.FindAsync(id);
            //_context.Loais.Remove(loai);
            _context.Remove(loai);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


      [HttpPost]
        public IActionResult TimAjax(string keyword)
        {
       
            if (!string.IsNullOrEmpty(keyword))
            {
               var  dsLoai = from p in _context.LoaiSPs
                        join c in _context.Users on p.idUser equals c.idUser
                        where p.tenLoaiSP.Contains(keyword) || p.metaTitle.Contains(keyword)
                       select new User_Loai
                        {
                            idLoaiSP = p.idLoaiSP,
                            hinhAnh = p.hinhAnh,
                            tenLoaiSP = p.tenLoaiSP,
                            typeLoai=p.typeLoai,
                            metaTitle = p.metaTitle,
                            trangThai = p.trangThai,
                            ngayTao = p.ngayTao,
                            ngayCapNhat = p.ngayCapNhat,
                            hoUser = c.hoUser,
                            tenUser = c.tenUser
                        };
                return PartialView(dsLoai);

            }

            var dsLoai2 = from p in _context.LoaiSPs
                         join c in _context.Users on p.idUser equals c.idUser
                        // where p.tenLoaiSP.Contains(keyword) || p.metaTitle.Contains(keyword)
                         select new User_Loai
                         {
                             idLoaiSP = p.idLoaiSP,
                             hinhAnh = p.hinhAnh,
                             tenLoaiSP = p.tenLoaiSP,
                            typeLoai=p.typeLoai,
                             metaTitle = p.metaTitle,
                             trangThai = p.trangThai,
                             ngayTao = p.ngayTao,
                             ngayCapNhat = p.ngayCapNhat,
                             hoUser = c.hoUser,
                             tenUser = c.tenUser
                         };






            return PartialView(dsLoai2);
        }


        private bool  LoaiSPExists(int id)
        {
            return _context.LoaiSPs.Any(e => e.idLoaiSP == id);
        }


    }
}
