using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            ViewBag.V1 = "Hizmet Listesi";
            ViewBag.V2 = "Hizmetler";
            ViewBag.V3 = "Hizmet Listesi";
            var values = serviceManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult ServiceAdd()
        {
            ViewBag.V1 = "Hizmet Ekleme";
            ViewBag.V2 = "Hizmetler";
            ViewBag.V3 = "Hizmet Ekleme";

            return View();
        }
        [HttpPost]
        public IActionResult ServiceAdd(Service p)
        {
            serviceManager.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult ServiceDelete(int id)
        {
            var values = serviceManager.GetByID(id);
            serviceManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ServiceEdit(int id)
        {
            ViewBag.V1 = "Hizmet Düzenleme";
            ViewBag.V2 = "Hizmetler";
            ViewBag.V3 = "Hizmet Düzenleme";
            var values = serviceManager.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult ServiceEdit(Service service)
        {
            serviceManager.TUpdate(service);
            return RedirectToAction("Index");
        }
    }
}
