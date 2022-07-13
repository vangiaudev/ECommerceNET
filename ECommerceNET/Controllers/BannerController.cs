using ECommerceNET.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceNET.Controllers
{
    public class BannerController : Controller
    {
        public IActionResult Index()
        {
            var ds = _context.Banners.Where(p => p.ngayBatDau <= DateTime.Now && p.ngayKetThuc >= DateTime.Now);
            return View(ds);
        }
        private readonly MyDBContext _context;

        public BannerController(MyDBContext context)
        {
            _context = context;
        }
    }
}
