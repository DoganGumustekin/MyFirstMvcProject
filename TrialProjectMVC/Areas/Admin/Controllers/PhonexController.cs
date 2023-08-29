using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using TrialProject.DataAccess.DBContext;
using TrialProject.DataAccess.Repository;
using TrialProject.DataAccess.Repository.IRepository;
using TrialProject.Models;

namespace TrialProjectMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PhonexController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public PhonexController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #region PhoneAdd
        public IActionResult Index()
        {
            List<PhoneModel> phoneModels = _unitOfWork.Phonex.GetAll().ToList();
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
                _unitOfWork.Phonex.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Yeni Kayıt Eklendi";
                return RedirectToAction("Index");
            }
            return View();
        }
        #endregion

        #region PhoneUpdate
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                TempData["error"] = "Kayıt Bulunamadı...";
                return NotFound();
            }
            PhoneModel phoneModel = _unitOfWork.Phonex.Get(p=>p.PhoneId==id);
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
                _unitOfWork.Phonex.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Kayıt Güncellendi";
                return RedirectToAction("Index");
            }
            return View();
        }
        #endregion

        #region PhoneDelete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                TempData["error"] = "Kayıt Bulunamadı...";
                return NotFound();
            }
            PhoneModel phoneModel = _unitOfWork.Phonex.Get(p => p.PhoneId == id);
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
            PhoneModel phoneModel = _unitOfWork.Phonex.Get(p => p.PhoneId == id);
            if (phoneModel == null)
            {
                TempData["error"] = "Kayıt Bulunamadı...";
                return NotFound();
            }
            _unitOfWork.Phonex.Remove(phoneModel);
            _unitOfWork.Save();
            TempData["success"] = "Kayıt Silindi";
            return RedirectToAction("Index");
        }
        #endregion

    }
}
