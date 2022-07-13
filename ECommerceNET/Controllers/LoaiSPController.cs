using ECommerceNET.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceNET.Controllers
{
    public class LoaiSPController : Controller
    {
        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }

        private readonly MyDBContext _context;

        public LoaiSPController(MyDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult LoaiTTNam()
        {
            var ds = _context.LoaiSPs.Where(p => p.typeLoai == "0" && p.trangThai =="Hiển thị");
            return View(ds);
        }

        [HttpPost]
        public IActionResult LoaiTTNu()
        {
            var ds = _context.LoaiSPs.Where(p => p.typeLoai == "1" && p.trangThai == "Hiển thị");
            return View(ds);
        }
    }
}
