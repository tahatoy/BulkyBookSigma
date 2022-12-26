using BulkBook.DataAccess.Repository.IRepository;
using BulkBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Areas.Admin.Controllers
{
    public class AdCategoriesController : Controller
    {
    private readonly IUnitOfWork _unitOfWork;

    public AdCategoriesController(IUnitOfWork unitOfWork)
    {
        _unitOfWork= unitOfWork;
    }
      public IActionResult Index()
      {
        IEnumerable<AdCategories> objAdCategoriesList = _unitOfWork.AdCategories.GetAll();
        return View(objAdCategoriesList);
      }
      public IActionResult Create(AdCategories obj)
      {
      if (ModelState.IsValid)
      {
        _unitOfWork.AdCategories.Add(obj);
        _unitOfWork.Save();
        TempData["success"] = "AdCategories created successfuly";
        return RedirectToAction("Index");
      }
      return View(obj);
      }
    }

}
