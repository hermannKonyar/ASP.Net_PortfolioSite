using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.V1 = "Düzenleme";
            ViewBag.V2 = "Öne Çıkanlar";
            ViewBag.V3 = "Öne Çıkanlar Sayfası";
            var values = featureManager.GetByID(1);
            return View(values);
        }


        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            featureManager.TUpdate(feature);
            return RedirectToAction("Index","Default");
        }
    }
}
