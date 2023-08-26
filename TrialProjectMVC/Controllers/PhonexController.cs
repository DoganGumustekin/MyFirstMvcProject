using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
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

        #region Ekleme
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
            if (obj.Phone == obj.Address)
            {
                ModelState.AddModelError("Address", "Adres alanı ile telefon alanı birbirine eşit olamaz...");
            }
            if (!obj.Address.IsNullOrEmpty() || !obj.Phone.IsNullOrEmpty())
            {
                if (obj.Address.ToLower() == "test")
                {

                    ModelState.AddModelError("", "Test yanlış bir değer");
                }

            }

            if (ModelState.IsValid)
            {
                _context.Phone.Add(obj);
                _context.SaveChanges();
                TempData["success"] = "Yeni Kayıt Eklendi";
                return RedirectToAction("Index");
            }
            return View();
        }
        #endregion

        #region Güncelleme
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                TempData["error"] = "Kayıt Bulunamadı...";
                return NotFound();
            }
            PhoneModel phoneModel = _context.Phone.Find(id);
            if (phoneModel == null)
            {
                TempData["error"] = "Kayıt Bulunamadı...";
                return NotFound();
            }
            return View(phoneModel);
        }

        [HttpPost]
        public IActionResult Edit(PhoneModel obj)
        {
            if (ModelState.IsValid)
            {
                _context.Phone.Update(obj);
                _context.SaveChanges();
                TempData["success"] = "Kayıt Güncellendi";
                return RedirectToAction("Index");
            }
            return View();
        }
        #endregion

        #region Silme
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                TempData["error"] = "Kayıt Bulunamadı...";
                return NotFound();
            }
            PhoneModel phoneModel = _context.Phone.Find(id);
            if (phoneModel == null)
            {
                TempData["error"] = "Kayıt Bulunamadı...";
                return NotFound();
            }
            return View(phoneModel);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            PhoneModel? phoneModel = _context.Phone.Find(id);
            if (phoneModel == null)
            {
                TempData["error"] = "Kayıt Bulunamadı...";
                return NotFound();
            }
            _context.Remove(phoneModel);
            _context.SaveChanges();
            TempData["success"] = "Kayıt Silindi";
            return RedirectToAction("Index");
        }
        #endregion

    }
}
