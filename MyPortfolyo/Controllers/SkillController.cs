using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolyo.DAL.Context;
using MyPortfolyo.DAL.Entities;

namespace MyPortfolyo.Controllers
{
    public class SkillController : Controller
    {
        MyPortfolioContext _context = new MyPortfolioContext();
        public IActionResult Index()
        {
			ViewBag.v1 = _context.Skills.Count();
			ViewBag.v2 = _context.Messages.Count();
			ViewBag.v3 = _context.Messages.Where(x => x.İsRead == false).Count();
			ViewBag.v4 = _context.Messages.Where(x => x.İsRead == true).Count();
			var skill = _context.Skills.ToList();
            return View(skill);
        }

        [HttpGet]
        public IActionResult SkilUpdate(int Id)
        {
            var value = _context.Skills.Find(Id);
            return View(value);
        }
        [HttpPost]
        public IActionResult SkilUpdate(Skill skill)
        {
            _context.Skills.Update(skill);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult SkillDelete(int Id)
        {
            var value = _context.Skills.Find(Id);
            _context.Skills.Remove(value);
            _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateSkill()
        {
        return View();

        }
        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            _context.Skills.Add(skill);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}
