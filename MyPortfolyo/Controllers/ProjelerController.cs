using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;

namespace MyPortfolyo.Controllers
{
	public class ProjelerController : Controller
	{ MyPortfolioContext _context=new MyPortfolioContext();
		public IActionResult Index()
		{
			var value= _context.Portfolios.ToList();	

			return View(value);
		}
	}
}
