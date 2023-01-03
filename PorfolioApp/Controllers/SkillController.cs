using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            ViewBag.V1 = "Yetenek Listesi";
            ViewBag.V2 = "Yetenekler";
            ViewBag.V3 = "Yetenek Listesi";
            var values = skillManager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult SkillAdd()
        {
            ViewBag.V1 = "Yetenek Ekleme";
            ViewBag.V2 = "Yetenekler";
            ViewBag.V3 = "Yetenek Ekleme";

            return View();
        }
        [HttpPost]
        public IActionResult SkillAdd(Skill p)
        {
            skillManager.TAdd(p);
            return RedirectToAction("Index");
        }
    }
}
