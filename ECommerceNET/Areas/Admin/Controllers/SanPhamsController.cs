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


namespace ECommerceNET.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SanPhamsController : Controller
    {

        private readonly MyDBContext _context;

        public SanPhamsController(MyDBContext context)
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
                = from p in _context.LoaiSPs
                  join c in _context.SanPhams on p.idLoaiSP equals c.idLoaiSP
                  orderby c.idSP descending 
                  // where p.ProductId == 2
                  select new Sanpham_Loai
                  {
                      idSP = c.idSP,
                      tenSP = c.tenSP,
                      giaSP = c.giaSP,
                      hinhAnh = c.hinhAnh,
                      luotMua = c.luotMua,
                      luotXem=c.luotXem,
                      soLuongKho=c.soLuongKho,
                      moTa =c.moTa,
                      LoaiSP=p.tenLoaiSP,
                      trangThai=c.trangThai,
                      ngayTao=c.ngayTao,
                      ngayCapNhat=c.ngayCapNhat,
                      
                  };





            return View(loaisp);
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
                 join c in _context.SanPhams on p.idLoaiSP equals c.idLoaiSP
                 where c.idSP == id
                 select new Sanpham_Loai
                 {
                     idSP = c.idSP,
                     tenSP = c.tenSP,
                     giaSP = c.giaSP,
                     hinhAnh = c.hinhAnh,
                     luotMua = c.luotMua,
                     luotXem = c.luotXem,
                     soLuongKho = c.soLuongKho,
                     moTa = c.moTa,
                     LoaiSP = p.tenLoaiSP,
                     trangThai = c.trangThai,
                     ngayTao = c.ngayTao,
                     ngayCapNhat = c.ngayCapNhat,

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

  
        public IActionResult LoadLoai()
        {
            return View(_context.LoaiSPs);
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
        public async Task<IActionResult> Create(SanPham loai, IFormFile hinhAnh)
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

                    var urlfull = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "sanpham", s);
                    using (var file = new FileStream(urlfull, FileMode.Create))
                    {
                        await hinhAnh.CopyToAsync(file);
                    }

                    loai.hinhAnh = s;
                }

              


                loai.ngayTao = DateTime.Now;
                loai.ngayCapNhat = DateTime.Now;
                _context.Add(loai);
                await _context.SaveChangesAsync();
                //   return RedirectToAction(nameof(Index));

            }
            return RedirectToAction("Index");

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

            var loaispx = await _context.SanPhams.FindAsync(id);
            

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
        public async Task<IActionResult> Edit(int id, SanPham loai, IFormFile hinhAnh)
        {
            if (id != loai.idSP)
            {
                return NotFound();
            }

            var loaix = _context.SanPhams
                .FirstOrDefault(p => p.idSP == id);

            if (ModelState.IsValid)
            {
                try
                {
                    if (hinhAnh == null)
                    {
                        loaix.tenSP = loai.tenSP;
                        loaix.giaSP = loai.giaSP;
                        loaix.soLuongKho = loai.soLuongKho;
                        loaix.moTa = loai.moTa;
                        loaix.idLoaiSP = loai.idLoaiSP;
                        loaix.trangThai = loai.trangThai;


                        loaix.ngayCapNhat = DateTime.Now;

                    }
                    else
                    {
                        loaix.tenSP = loai.tenSP;
                        loaix.giaSP = loai.giaSP;
                        loaix.soLuongKho = loai.soLuongKho;
                        loaix.moTa = loai.moTa;
                        loaix.idLoaiSP = loai.idLoaiSP;
                        loaix.trangThai = loai.trangThai;

                        loaix.ngayCapNhat = DateTime.Now;

                        string format = "yyyy_MM_dd_HH_mm_ss";

                        DateTime now = DateTime.Now;

                        string s = now.ToString(format) + ".jpg";

                        var urlfull = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "sanpham", s);
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
                    if (!LoaiSPExists(loai.idSP))

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

        private bool LoaiSPExists(int id)
        {
            return _context.SanPhams.Any(e => e.idSP == id);
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
                 join c in _context.SanPhams on p.idLoaiSP equals c.idLoaiSP
                 where c.idSP == id
                 // where p.ProductId == 2
                 select new Sanpham_Loai
                 {
                     idSP = c.idSP,
                     tenSP = c.tenSP,
                     giaSP = c.giaSP,
                     hinhAnh = c.hinhAnh,
                     luotMua = c.luotMua,
                     luotXem = c.luotXem,
                     soLuongKho = c.soLuongKho,
                     moTa = c.moTa,
                     LoaiSP = p.tenLoaiSP,
                     trangThai = c.trangThai,
                     ngayTao = c.ngayTao,
                     ngayCapNhat = c.ngayCapNhat,

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
            var loai = await _context.SanPhams.FindAsync(id);
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
                var dsLoai = from p in _context.LoaiSPs
                             join c in _context.SanPhams on p.idLoaiSP equals c.idLoaiSP
                             where c.tenSP.Contains(keyword) 
                             select new Sanpham_Loai
                             {
                                 idSP = c.idSP,
                                 tenSP = c.tenSP,
                                 giaSP = c.giaSP,
                                 hinhAnh = c.hinhAnh,
                                 luotMua = c.luotMua,
                                 luotXem = c.luotXem,
                                 soLuongKho = c.soLuongKho,
                                 moTa = c.moTa,
                                 LoaiSP = p.tenLoaiSP,
                                 trangThai = c.trangThai,
                                 ngayTao = c.ngayTao,
                                 ngayCapNhat = c.ngayCapNhat,
                             };
                return PartialView(dsLoai);

            }

            var dsLoai2 = from p in _context.LoaiSPs
                          join c in _context.SanPhams on p.idLoaiSP equals c.idLoaiSP
                          // where p.tenLoaiSP.Contains(keyword) || p.metaTitle.Contains(keyword)
                          select new Sanpham_Loai
                          {
                              idSP = c.idSP,
                              tenSP = c.tenSP,
                              giaSP = c.giaSP,
                              hinhAnh = c.hinhAnh,
                              luotMua = c.luotMua,
                              luotXem = c.luotXem,
                              soLuongKho = c.soLuongKho,
                              moTa = c.moTa,
                              LoaiSP = p.tenLoaiSP,
                              trangThai = c.trangThai,
                              ngayTao = c.ngayTao,
                              ngayCapNhat = c.ngayCapNhat,
                          };






            return PartialView(dsLoai2);
        }

    }
}
