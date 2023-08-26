using Microsoft.AspNetCore.Mvc;
using TrialProjectMVC.DBContext;
using TrialProjectMVC.Models;

namespace TrialProjectMVC.Controllers
{
    public class PhonexController : Controller
    {
        private readonly TrialEFContextMVC _context;

        public PhonexController(TrialEFContextMVC context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<PhoneModel> phoneModels = _context.Phone.ToList();
            return View(phoneModels);
        }

        public IActionResult PhoneAdd()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult PhoneAdd(PhoneModel obj)
        {
            _context.Phone.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
