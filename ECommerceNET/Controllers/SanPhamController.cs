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
    public class SanPhamController : Controller
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
            }
            else
            {
                ViewBag.houser = "TÀI";
                ViewBag.tenuser = "KHOẢN";
                ViewBag.accmenu1 = "Đăng nhập";
            }
            return View();
        }

        //[Route("Sanpham/Chitiet/{slug}-{id:int}")]
        [Route("/{slug}-{id:int}")]
        public IActionResult chitiet(int? id)
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
            }
            else
            {
                ViewBag.houser = "TÀI";
                ViewBag.tenuser = "KHOẢN";
                ViewBag.accmenu1 = "Đăng nhập";
            }



            var ctx = _context.SanPhams
               .Where(p => p.idSP == id);

            var ct = _context.SanPhams
                .FirstOrDefault(p => p.idSP == id);

            ct.luotXem++;

            _context.Update(ct);
            _context.SaveChanges();
            var hostname = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}";

            ViewBag.url = hostname + "/" + SlugGenerator.SlugGenerator.GenerateSlug(ct.tenSP) + "/";
            ViewBag.title = ct.tenSP + " - YAN Store";
            ViewBag.description = ct.moTa;
            ViewBag.img = hostname + "/images/sanpham/" + ct.hinhAnh;
            return View(ctx);
        }

       
        public IActionResult timkiem(string id)
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
            }
            else
            {
                ViewBag.houser = "TÀI";
                ViewBag.tenuser = "KHOẢN";
                ViewBag.accmenu1 = "Đăng nhập";
            }
            var ct = _context.SanPhams
                .Where(p => p.tenSP.Contains(id) && p.soLuongKho>0 && p.trangThai=="Hiển thị");
            return View(ct);
        }


        private readonly MyDBContext _context;

        public SanPhamController(MyDBContext context)
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

        [HttpPost]
        
        public IActionResult sanphambanchay()
        {
            var products = _context.SanPhams
                .Where(p => p.trangThai == "Hiển thị" && p.soLuongKho>0)
                //      .Where(p => p.luotMua > 100)              // Lọc các sản phẩm giá trên 100
                .OrderByDescending(p => p.luotMua)        // Sắp xếp giảm dần, tăng dần là OrderBy
                .Take(8);
            return View(products);
        }

        [HttpPost]
        
        public IActionResult sanphammoi()
        {
            var products = _context.SanPhams
                //      .Where(p => p.luotMua > 100)  
                .Where(p => p.trangThai == "Hiển thị" && p.soLuongKho>0)           // Lọc các sản phẩm giá trên 100
                .OrderByDescending(p => p.idSP)        // Sắp xếp giảm dần, tăng dần là OrderBy
                .Take(8);
          
            return View(products);
        }

        [HttpPost]
        
        public IActionResult sanphamnoibat()
        {
            var products = _context.SanPhams
                //      .Where(p => p.luotMua > 100)              // Lọc các sản phẩm giá trên 100
                .OrderByDescending(p => p.luotXem)        // Sắp xếp giảm dần, tăng dần là OrderBy
                .Where(p=> p.trangThai == "Hiển thị" && p.soLuongKho>0)
                .Take(8);
            return View(products);
        }


        // [Route("Sanpham/loaisp/{slug}-{id:int}")]
        [Route("Sanpham/loaisp/{slug}-{id:int}")]
        public IActionResult loaisp(int? id)
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
            }
            else
            {
                ViewBag.houser = "TÀI";
                ViewBag.tenuser = "KHOẢN";
                ViewBag.accmenu1 = "Đăng nhập";
            }
            if (id == null)
            {
                NotFound();
            }
            var products = _context.SanPhams
                .Where(p => p.idLoaiSP == id && p.trangThai=="Hiển thị" && p.soLuongKho>0);
            //      .Where(p => p.luotMua > 100)              // Lọc các sản phẩm giá trên 100
            // Sắp xếp giảm dần, tăng dần là OrderBy
            ViewBag.mess = id;
            return View(products);
        }


       [HttpPost]
        
        public IActionResult TimAjax(string keyword, string kw2,string kw3,string idloai)
        {
     
            string dssp2 = kw2;
            string dssp3 = kw3;
      
            int idloaix = Int32.Parse(idloai);
            if (!string.IsNullOrEmpty(keyword))

            {
                if (dssp2 == "0")
                {
                    if (dssp3 == "0")
                    {
                         var product = _context.SanPhams
                          .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị" && p.tenSP.Contains(keyword));
                           return PartialView(product);
                    }
                    else if (dssp3 == "1")
                    {
                        var product = _context.SanPhams
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị" && p.tenSP.Contains(keyword) && p.giaSP>=50000 && p.giaSP<=100000);
                        return PartialView(product);
                    }

                    else if (dssp3 == "2")
                    {
                        var product = _context.SanPhams
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị" && p.tenSP.Contains(keyword) && p.giaSP >= 101000 && p.giaSP <= 300000);
                        return PartialView(product);
                    }

                    else if (dssp3 == "3")
                    {
                        var product = _context.SanPhams
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị" && p.tenSP.Contains(keyword) && p.giaSP >= 301000 && p.giaSP <= 500000);
                        return PartialView(product);
                    }

                }
                else if (dssp2 == "1")
                {
                    if (dssp3 == "0")
                    {
                        var product = _context.SanPhams
                             .OrderByDescending(p => p.idSP)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị" && p.tenSP.Contains(keyword));
                        return PartialView(product);
                    }
                    else if (dssp3 == "1")
                    {
                        var product = _context.SanPhams
                             .OrderByDescending(p => p.idSP)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị" && p.tenSP.Contains(keyword) && p.giaSP >= 50000 && p.giaSP <= 100000);
                        return PartialView(product);
                    }

                    else if (dssp3 == "2")
                    {

                        var product = _context.SanPhams
                             .OrderByDescending(p => p.idSP)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị" && p.tenSP.Contains(keyword) && p.giaSP >= 101000 && p.giaSP <= 300000);
                        return PartialView(product);
                    }

                    else if (dssp3 == "3")
                    {
                        var product = _context.SanPhams
                             .OrderByDescending(p => p.idSP)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị" && p.tenSP.Contains(keyword) && p.giaSP >= 301000 && p.giaSP <= 500000);
                        return PartialView(product);
                    }

                }


                else if (dssp2 == "2")
                {
                    if (dssp3 == "0")
                    {
                        var product = _context.SanPhams
                             .OrderByDescending(p => p.luotMua)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị" && p.tenSP.Contains(keyword));
                        return PartialView(product);
                    }
                    else if (dssp3 == "1")
                    {
                        var product = _context.SanPhams
                             .OrderByDescending(p => p.luotMua)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị" && p.tenSP.Contains(keyword) && p.giaSP >= 50000 && p.giaSP <= 100000);
                        return PartialView(product);
                    }

                    else if (dssp3 == "2")
                    {

                        var product = _context.SanPhams
                             .OrderByDescending(p => p.luotMua)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị" && p.tenSP.Contains(keyword) && p.giaSP >= 101000 && p.giaSP <= 300000);
                        return PartialView(product);
                    }

                    else if (dssp3 == "3")
                    {
                        var product = _context.SanPhams
                             .OrderByDescending(p => p.luotMua)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị" && p.tenSP.Contains(keyword) && p.giaSP >= 301000 && p.giaSP <= 500000);
                        return PartialView(product);
                    }

                }


                else if (dssp2 == "3")
                {
                    if (dssp3 == "0")
                    {
                        var product = _context.SanPhams
                             .OrderByDescending(p => p.luotXem)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị" && p.tenSP.Contains(keyword));
                        return PartialView(product);
                    }
                    else if (dssp3 == "1")
                    {
                        var product = _context.SanPhams
                             .OrderByDescending(p => p.luotXem)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị" && p.tenSP.Contains(keyword) && p.giaSP >= 50000 && p.giaSP <= 100000);
                        return PartialView(product);
                    }

                    else if (dssp3 == "2")
                    {

                        var product = _context.SanPhams
                             .OrderByDescending(p => p.luotXem)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị" && p.tenSP.Contains(keyword) && p.giaSP >= 101000 && p.giaSP <= 300000);
                        return PartialView(product);
                    }

                    else if (dssp3 == "3")
                    {
                        var product = _context.SanPhams
                             .OrderByDescending(p => p.luotXem)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị" && p.tenSP.Contains(keyword) && p.giaSP >= 301000 && p.giaSP <= 500000);
                        return PartialView(product);
                    }

                }




            }



            else
            {
                if (dssp2 == "0")
                {
                    if (dssp3 == "0")
                    {
                        var product = _context.SanPhams
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị");
                        return PartialView(product);
                    }
                    else if (dssp3 == "1")
                    {
                        var product = _context.SanPhams
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị" &&  p.giaSP >= 50000 && p.giaSP <= 100000);
                        return PartialView(product);
                    }

                    else if (dssp3 == "2")
                    {
                        var product = _context.SanPhams
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị" && p.giaSP >= 101000 && p.giaSP <= 300000);
                        return PartialView(product);
                    }

                    else if (dssp3 == "3")
                    {
                        var product = _context.SanPhams
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị" &&  p.giaSP >= 301000 && p.giaSP <= 500000);
                        return PartialView(product);
                    }

                }
                else if (dssp2 == "1")
                {
                    if (dssp3 == "0")
                    {
                        var product = _context.SanPhams
                             .OrderByDescending(p => p.idSP)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị" );
                        return PartialView(product);
                    }
                    else if (dssp3 == "1")
                    {
                        var product = _context.SanPhams
                             .OrderByDescending(p => p.idSP)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị"  && p.giaSP >= 50000 && p.giaSP <= 100000);
                        return PartialView(product);
                    }

                    else if (dssp3 == "2")
                    {

                        var product = _context.SanPhams
                             .OrderByDescending(p => p.idSP)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị"  && p.giaSP >= 101000 && p.giaSP <= 300000);
                        return PartialView(product);
                    }

                    else if (dssp3 == "3")
                    {
                        var product = _context.SanPhams
                             .OrderByDescending(p => p.idSP)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị" && p.giaSP >= 301000 && p.giaSP <= 500000);
                        return PartialView(product);
                    }

                }


                else if (dssp2 == "2")
                {
                    if (dssp3 == "0")
                    {
                        var product = _context.SanPhams
                             .OrderByDescending(p => p.luotMua)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị");
                        return PartialView(product);
                    }
                    else if (dssp3 == "1")
                    {
                        var product = _context.SanPhams
                             .OrderByDescending(p => p.luotMua)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị"  && p.giaSP >= 50000 && p.giaSP <= 100000);
                        return PartialView(product);
                    }

                    else if (dssp3 == "2")
                    {

                        var product = _context.SanPhams
                             .OrderByDescending(p => p.luotMua)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị"  && p.giaSP >= 101000 && p.giaSP <= 300000);
                        return PartialView(product);
                    }

                    else if (dssp3 == "3")
                    {
                        var product = _context.SanPhams
                             .OrderByDescending(p => p.luotMua)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị"  && p.giaSP >= 301000 && p.giaSP <= 500000);
                        return PartialView(product);
                    }

                }


                else if (dssp2 == "3")
                {
                    if (dssp3 == "0")
                    {
                        var product = _context.SanPhams
                             .OrderByDescending(p => p.luotXem)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị" );
                        return PartialView(product);
                    }
                    else if (dssp3 == "1")
                    {
                        var product = _context.SanPhams
                             .OrderByDescending(p => p.luotXem)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị"  && p.giaSP >= 50000 && p.giaSP <= 100000);
                        return PartialView(product);
                    }

                    else if (dssp3 == "2")
                    {

                        var product = _context.SanPhams
                             .OrderByDescending(p => p.luotXem)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị"  && p.giaSP >= 101000 && p.giaSP <= 300000);
                        return PartialView(product);
                    }

                    else if (dssp3 == "3")
                    {
                        var product = _context.SanPhams
                             .OrderByDescending(p => p.luotXem)
                         .Where(p => p.idLoaiSP == idloaix && p.trangThai == "Hiển thị"  && p.giaSP >= 301000 && p.giaSP <= 500000);
                        return PartialView(product);
                    }

                }




            }

            var products = _context.SanPhams
               .Where(p => p.idLoaiSP == idloaix || p.trangThai == "Hiển thị");





            return PartialView(products);
        }




    }
}
