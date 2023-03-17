using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.V1 = "Proje Listesi";
            ViewBag.V2 = "Projeler";
            ViewBag.V3 = "Proje Listesi";
            var values = portfolioManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.V1 = "Proje Listesi";
            ViewBag.V2 = "Projeler";
            ViewBag.V3 = "Proje Ekleme";
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
            
            

            PortfolioValidator validator = new PortfolioValidator();
            ValidationResult results= validator.Validate(p);
            if(results.IsValid)
            {
                portfolioManager.TAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();   
            
        }

        public IActionResult DeletePortfolio(int id)
        {
            var values=portfolioManager.GetByID(id);
            portfolioManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult PortfolioEdit(int id)
        {
            ViewBag.V1 = "Proje Düzenleme";
            ViewBag.V2 = "Projeler";
            ViewBag.V3 = "Proje Düzenleme";
            var values = portfolioManager.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult PortfolioEdit(Portfolio portfolio)
        {
            PortfolioValidator validation= new PortfolioValidator();
            ValidationResult results= validation.Validate(portfolio);
            if (results.IsValid)
            {
                portfolioManager.TUpdate(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
        }
    }
}
