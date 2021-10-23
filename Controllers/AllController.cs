using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarLib.Models;

namespace CarLib.Controllers
{
    public class AllController : Controller
    {
        private readonly CarLibContext _context;

        public AllController(CarLibContext context)
        {
            _context = context;
        }

        // GET: AllController
        public async Task<IActionResult> Index()
        {
            var brands = _context.Brands.Include(m => m.Models).AsNoTracking();

            return View(await brands.ToListAsync());
        }
    }
}
