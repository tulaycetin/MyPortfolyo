using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolyo.DAL.Context;
using MyPortfolyo.DAL.Entities;
using Newtonsoft.Json.Linq;

namespace MyPortfolyo.Controllers
{
    public class ExperienceController : Controller
    {  MyPortfolioContext _context=new MyPortfolioContext();

        public IActionResult ExperienceList()
        {
            var values = _context.Experinces.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateExperience() 
        {
           return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experince experince) 
        { 
            _context.Experinces.Add(experince);
            _context.SaveChanges();
           return RedirectToAction("ExperienceList");
        }
	
		public IActionResult DeleteExperience(int Id)
		{
			var value =_context.Experinces.Find(Id);
            _context.Experinces.Remove(value);
			_context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
        [HttpGet]
		public IActionResult UpdateExperience(int Id)
		{
			var value = _context.Experinces.Find(Id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateExperience(Experince experince)
		{
			_context.Experinces.Update(experince);
			_context.SaveChanges();
			return RedirectToAction("ExperienceList");

		}
	}
}
