using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;

namespace MyPortfolyo.Controllers
{
	public class StatisticController : Controller
	{
		MyPortfolioContext _context =new MyPortfolioContext();
		public IActionResult Index()
		{
			ViewBag.v1 = _context.Skills.Count();
			ViewBag.v2 = _context.Messages.Count();
			ViewBag.v3 = _context.Messages.Where(x=>x.İsRead==false).Count();
			ViewBag.v4 = _context.Messages.Where(x=>x.İsRead==true).Count();

			return View();
		}
	}
}
