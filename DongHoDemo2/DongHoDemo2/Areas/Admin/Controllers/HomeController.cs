using DongHoDemo2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DongHoDemo2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DongHoDemoContext _context;

        public HomeController(DongHoDemoContext context)
        {
            _context = context;
        }
        [Route("Admin")]
        public IActionResult Index()
        {
            var listOrders = _context.Orders
                .AsNoTracking()
                .Where(x => x.TransactStatusId == 4)
                .ToList();
            var listProducts = _context.Products
                .AsNoTracking()
                .ToList();
            var listCustomers = _context.Customers
                .AsNoTracking()
                .ToList();
            ViewBag.listOrders = listOrders;
            ViewBag.listProducts = listProducts;
            ViewBag.listCustomers = listCustomers;
            return View();
        }
    }
}
