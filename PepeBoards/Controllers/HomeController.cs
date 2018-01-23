using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PepeBoards.Data;
using PepeBoards.Models;
using Microsoft.EntityFrameworkCore;

namespace PepeBoards.Controllers
{
    public class HomeController : Controller
    {
        private readonly Data.ApplicationDbContext _context;

        public HomeController(Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var forums = _context.Forum
                .Include(f => f.Subforums);
            ViewData["Forums"] = forums;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
