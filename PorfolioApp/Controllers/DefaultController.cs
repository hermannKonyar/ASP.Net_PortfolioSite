using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Project.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavBarPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult SenMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SenMessage(Message m)
        {
            MessageManager messageManager = new MessageManager(new EfMessageDal());
            m.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            m.Status = true;
            messageManager.TAdd(m);
            return PartialView();
        }
    }
}
