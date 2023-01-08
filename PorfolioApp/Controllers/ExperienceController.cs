using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.V1 = "Deneyim Listesi";
            ViewBag.V2 = "Deneyimler";
            ViewBag.V3 = "Deneyim Listesi";
            var values = experienceManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult ExperienceAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ExperienceAdd(Experience experience)
        {
            experienceManager.TAdd(experience);
            return RedirectToAction("Index");
        }

        public IActionResult ExperienceDelete(int id)
        {
            var values = experienceManager.GetByID(id);
            experienceManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ExperienceEdit(int id)
        {
            ViewBag.V1 = "Deneyim Listesi";
            ViewBag.V2 = "Deneyimler";
            ViewBag.V3 = "Deneyim Listesi";
            var values = experienceManager.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult ExperienceEdit(Experience experience)
        {
            experienceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }

    }
}
