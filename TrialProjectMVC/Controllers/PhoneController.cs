using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrialProjectMVC.DBContext;
using TrialProjectMVC.Models;
using System.Threading.Tasks;

namespace TrialProjectMVC.Controllers
{
    public class PhoneController : Controller
    {
        private readonly TrialEFContextMVC _context;

        public PhoneController(TrialEFContextMVC context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var phones = await _context.Phone.ToListAsync();
            return View(phones);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PhoneModel phone)
        {
            if (ModelState.IsValid)
            {
                _context.Phone.Add(phone);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(phone);
        }
    }
}
