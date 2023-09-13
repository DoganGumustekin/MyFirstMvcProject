using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using TrialProject.DataAccess.DBContext;
using TrialProject.DataAccess.Repository;
using TrialProject.DataAccess.Repository.IRepository;
using TrialProject.Models;

namespace TrialProjectMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #region ProductAdd
        public IActionResult Index()
        {
            List<ProductModel> productModel = _unitOfWork.Product.GetAll().ToList();
            return View(productModel);
        }

        public IActionResult ProductAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProductAdd(ProductModel obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Product.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Yeni Kayıt Eklendi";
                return RedirectToAction("Index");
            }
            return View();
        }
        #endregion

        #region ProductUpdate
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                TempData["error"] = "Kayıt Bulunamadı...";
                return NotFound();
            }
            ProductModel productModel = _unitOfWork.Product.Get(p=>p.ProductID==id);
            if (productModel == null)
            {
                TempData["error"] = "Kayıt Bulunamadı...";
                return NotFound();
            }
            return View(productModel);
        }

        [HttpPost]
        public IActionResult Edit(ProductModel obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Product.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Kayıt Güncellendi";
                return RedirectToAction("Index");
            }
            return View();
        }
        #endregion

        #region ProductDelete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                TempData["error"] = "Kayıt Bulunamadı...";
                return NotFound();
            }
            ProductModel productModel = _unitOfWork.Product.Get(p => p.ProductID == id);
            if (productModel == null)
            {
                TempData["error"] = "Kayıt Bulunamadı...";
                return NotFound();
            }
            return View(productModel);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            ProductModel productModel = _unitOfWork.Product.Get(p => p.ProductID == id);
            if (productModel == null)
            {
                TempData["error"] = "Kayıt Bulunamadı...";
                return NotFound();
            }
            _unitOfWork.Product.Remove(productModel);
            _unitOfWork.Save();
            TempData["success"] = "Kayıt Silindi";
            return RedirectToAction("Index");
        }
        #endregion

    }
}
