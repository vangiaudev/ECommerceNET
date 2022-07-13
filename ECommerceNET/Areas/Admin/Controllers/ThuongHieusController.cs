
using ECommerceNET.Areas.Admin.Models;
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
    public class ThuongHieusController : Controller
    {
        private readonly MyDBContext _context;

        public ThuongHieusController(MyDBContext context)
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
            var loaisp
                = from p in _context.ThuongHieus
                  join c in _context.Users on p.idUser equals c.idUser
                  // where p.ProductId == 2
                  select new User_ThuongHieu
                  {
                      idThuongHieu=p.idThuongHieu,
                      tenThuongHieu=p.tenThuongHieu,
                      hinhLogo=p.hinhLogo,
                      sdtThuongHieu=p.sdtThuongHieu,
                      emailThuongHieu=p.emailThuongHieu,
                      trangThai=p.trangThai,
                      ngayTao=p.ngayTao,
                      ngayCapNhat=p.ngayCapNhat,
                      hoUser=c.hoUser,
                      tenUser=c.tenUser,
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
                = from p in _context.ThuongHieus
                  join c in _context.Users on p.idUser equals c.idUser
                  where p.idThuongHieu == id
                  select new User_ThuongHieu
                  {
                      idThuongHieu = p.idThuongHieu,
                      tenThuongHieu = p.tenThuongHieu,
                      hinhLogo = p.hinhLogo,
                      sdtThuongHieu = p.sdtThuongHieu,
                      emailThuongHieu = p.emailThuongHieu,
                      trangThai = p.trangThai,
                      ngayTao = p.ngayTao,
                      ngayCapNhat = p.ngayCapNhat,
                      hoUser = c.hoUser,
                      tenUser = c.tenUser,
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
        public async Task<IActionResult> Create(ThuongHieu loai, IFormFile hinhAnh)
        {
            
                if (hinhAnh != null)
                {
                    // DateTime hientai = DateTime.UtcNow;
                    // string htai = hientai.ToLongDateString();


                    string format = "yyyy_MM_dd_HH_mm_ss";

                    DateTime now = DateTime.Now;

                    string s = now.ToString(format) + ".jpg";

                    var urlfull = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "logo", s);
                    using (var file = new FileStream(urlfull, FileMode.Create))
                    {
                        await hinhAnh.CopyToAsync(file);
                    }

                    loai.hinhLogo= s;
                }

                loai.idUser = ssuser.idUser;


                loai.ngayTao = DateTime.Now;
                loai.ngayCapNhat = DateTime.Now;
                _context.Add(loai);
                await _context.SaveChangesAsync();
                //   return RedirectToAction(nameof(Index));

            
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

            var loaispx = await _context.ThuongHieus.FindAsync(id);
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
        public async Task<IActionResult> Edit(int id, ThuongHieu loai, IFormFile hinhAnh)
        {
            if (id != loai.idThuongHieu)
            {
                return NotFound();
            }

            var loaix = _context.ThuongHieus
                .FirstOrDefault(p => p.idThuongHieu == id);

            if (ModelState.IsValid)
            {
                try
                {
                    if (hinhAnh == null)
                    {
                        loaix.tenThuongHieu = loai.tenThuongHieu;
                        loaix.hinhLogo = loai.hinhLogo;
                        loaix.sdtThuongHieu = loai.sdtThuongHieu;
                        loaix.emailThuongHieu = loai.emailThuongHieu;


                        loaix.trangThai = loai.trangThai;





                        loaix.ngayCapNhat = DateTime.Now;

                    }
                    else
                    {
                        loaix.tenThuongHieu = loai.tenThuongHieu;
                        loaix.hinhLogo = loai.hinhLogo;
                        loaix.sdtThuongHieu = loai.sdtThuongHieu;
                        loaix.emailThuongHieu = loai.emailThuongHieu;


                        loaix.trangThai = loai.trangThai;

                        loaix.ngayCapNhat = DateTime.Now;

                        string format = "yyyy_MM_dd_HH_mm_ss";

                        DateTime now = DateTime.Now;

                        string s = now.ToString(format) + ".jpg";

                        var urlfull = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "logo", s);
                        using (var file = new FileStream(urlfull, FileMode.Create))
                        {
                            await hinhAnh.CopyToAsync(file);
                        }

                        loaix.hinhLogo = s;



                    }



                    _context.Update(loaix);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThuongHieusExists(loai.idThuongHieu))

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
                 = from p in _context.ThuongHieus
                   join c in _context.Users on p.idUser equals c.idUser
                   where p.idThuongHieu == id
                   select new User_ThuongHieu
                   {
                       idThuongHieu = p.idThuongHieu,
                       tenThuongHieu = p.tenThuongHieu,
                       hinhLogo = p.hinhLogo,
                       sdtThuongHieu = p.sdtThuongHieu,
                       emailThuongHieu = p.emailThuongHieu,
                       trangThai = p.trangThai,
                       ngayTao = p.ngayTao,
                       ngayCapNhat = p.ngayCapNhat,
                       hoUser = c.hoUser,
                       tenUser = c.tenUser,

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
            var loai = await _context.ThuongHieus.FindAsync(id);
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
                var dsLoai = from p in _context.ThuongHieus
                             join c in _context.Users on p.idUser equals c.idUser
                             where p.tenThuongHieu.Contains(keyword) || p.sdtThuongHieu.Contains(keyword) || p.emailThuongHieu.Contains(keyword)
                             select new User_ThuongHieu
                             {
                                 idThuongHieu = p.idThuongHieu,
                                 tenThuongHieu = p.tenThuongHieu,
                                 hinhLogo = p.hinhLogo,
                                 sdtThuongHieu = p.sdtThuongHieu,
                                 emailThuongHieu = p.emailThuongHieu,
                                 trangThai = p.trangThai,
                                 ngayTao = p.ngayTao,
                                 ngayCapNhat = p.ngayCapNhat,
                                 hoUser = c.hoUser,
                                 tenUser = c.tenUser,
                             };
                return PartialView(dsLoai);

            }

            var dsLoai2 = from p in _context.ThuongHieus
                          join c in _context.Users on p.idUser equals c.idUser
                          // where p.tenLoaiSP.Contains(keyword) || p.metaTitle.Contains(keyword)
                          select new User_ThuongHieu
                          {
                              idThuongHieu = p.idThuongHieu,
                              tenThuongHieu = p.tenThuongHieu,
                              hinhLogo = p.hinhLogo,
                              sdtThuongHieu = p.sdtThuongHieu,
                              emailThuongHieu = p.emailThuongHieu,
                              trangThai = p.trangThai,
                              ngayTao = p.ngayTao,
                              ngayCapNhat = p.ngayCapNhat,
                              hoUser = c.hoUser,
                              tenUser = c.tenUser,
                          };






            return PartialView(dsLoai2);
        }

        private bool ThuongHieusExists(int id)
        {
            return _context.LoaiSPs.Any(e => e.idLoaiSP == id);
        }



    }
}
