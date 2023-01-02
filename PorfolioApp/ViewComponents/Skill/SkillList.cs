using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Skill
{
    public class SkillList : ViewComponent
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IViewComponentResult Invoke()
        {
            var item = skillManager.GetList();
            return View(item);

        }
    }
}
