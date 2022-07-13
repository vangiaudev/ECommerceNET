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
    public class UsersController : Controller
    {
        


        private readonly MyDBContext _context;

        public UsersController(MyDBContext context)
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
            return View(_context.Users);
        }

        [HttpPost]
        public IActionResult TimAjax(string keyword)
        {
            var dsusers = _context.Users.AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                dsusers = dsusers.Where(p => p.hoUser.Contains(keyword) || p.tenUser.Contains(keyword) || p.sdtUser.Contains(keyword) || p.emailUser.Contains(keyword));

             //   return PartialView(dsLoai);

            }

            var data = dsusers.Select(p => new User {
            
                idUser=p.idUser,
                hoUser=p.hoUser,
                tenUser=p.tenUser,
                sdtUser=p.sdtUser,
                emailUser=p.emailUser,
                ngayTao=p.ngayTao,
                ngayCapNhat=p.ngayCapNhat,
                hoatDongLanCuoi=p.hoatDongLanCuoi,
                trangThai=p.trangThai,
                hinhAVT=p.hinhAVT,
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
        public async Task<IActionResult> Create(User user, IFormFile hinhAnh)
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

                    var urlfull = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "user", s);
                    using (var file = new FileStream(urlfull, FileMode.Create))
                    {
                        await hinhAnh.CopyToAsync(file);
                    }

                    user.hinhAVT = s;

                }
                else
                {
                    user.hinhAVT = "def.jpg";
                }
                user.matKhau = GetMD5(user.matKhau).ToLower();
                user.ngayTao = DateTime.Now;
                user.ngayCapNhat = DateTime.Now;
                user.hoatDongLanCuoi = DateTime.Now;
                _context.Add(user);
                await _context.SaveChangesAsync();
                //   return RedirectToAction(nameof(Index));

            }
            return RedirectToAction("Index");

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

            var loaispx = await _context.Users.FindAsync(id);
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


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, User user, IFormFile hinhAnh)
        {
            if (id != user.idUser)
            {
                return NotFound();
            }

            var xx = _context.Users
                .FirstOrDefault(p => p.idUser == id);


                try
                {
                    if (hinhAnh == null)
                    {
                        xx.hoUser = user.hoUser;
                        xx.tenUser = user.tenUser;
                        xx.sdtUser = user.sdtUser;
                        xx.emailUser = user.emailUser;
                        xx.gioiTinh = user.gioiTinh;
                        xx.ngaySinh = user.ngaySinh;
                        xx.diaChi = user.diaChi;
                        xx.trangThai = user.trangThai;
                        xx.vaiTro = user.vaiTro;



                        xx.ngayCapNhat = DateTime.Now;
                   
                }
                    else
                    {
                       
                        user.ngayCapNhat = DateTime.Now;

                        string format = "yyyy_MM_dd_HH_mm_ss";

                        DateTime now = DateTime.Now;

                        string s = now.ToString(format) + ".jpg";

                        var urlfull = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "user", s);
                        using (var file = new FileStream(urlfull, FileMode.Create))
                        {
                            await hinhAnh.CopyToAsync(file);
                        }

                        xx.hinhAVT = s;

                        xx.hoUser = user.hoUser;
                        xx.tenUser = user.tenUser;
                        xx.sdtUser = user.sdtUser;
                        xx.emailUser = user.emailUser;
                        xx.gioiTinh = user.gioiTinh;
                        xx.ngaySinh = user.ngaySinh;
                        xx.diaChi = user.diaChi;
                        xx.trangThai = user.trangThai;
                        xx.vaiTro = user.vaiTro;



                        xx.ngayCapNhat = DateTime.Now;


                    }



                    _context.Update(xx);
                    await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.idUser))

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


        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.idUser == id);
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
            var xx = _context.Users
                .FirstOrDefault(p => p.idUser == id);

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
            var loai = await _context.Users.FindAsync(id);
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


            var xx = _context.Users
                .FirstOrDefault(p => p.idUser == id);




            if (xx == null)
            {
                return NotFound();
            }

            return View(xx);
        }


    }
}
