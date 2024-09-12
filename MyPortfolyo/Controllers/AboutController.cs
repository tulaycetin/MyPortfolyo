using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;
using MyPortfolyo.DAL.Entities;

namespace MyPortfolyo.Controllers
{
	public class AboutController : Controller
	{
		MyPortfolioContext _context = new MyPortfolioContext();
        public IActionResult about()
		{
			var about= _context.Abouts.ToList();
	    	  return View(about);
		}
	
		public ActionResult DeleteAbout(int Id)
		{
			var value = _context.Abouts.Find(Id);
			_context.Abouts.Remove(value);
			_context.SaveChangesAsync();
			return RedirectToAction("about");
		}
		public IActionResult AboutDetail(int Id)
		{
            var value = _context.Abouts.Find(Id);
            return View(value);
        }
		[HttpGet]
		public IActionResult UpdateAboutDetail(int Id)
		{
			var value = _context.Abouts.Find(Id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateAboutDetail(About about)
		{
			_context.Abouts.Update(about);
			_context.SaveChanges();
			return RedirectToAction("about");
		}
	


    }
}
