using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;

namespace MyPortfolyo.ViewComponents.LayoutViewComponent
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
		MyPortfolioContext _context = new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			ViewBag.toDoListCount = _context.ToDoLists.Where(x => x.Status == false).Count(); //Okunmamış bildirimlerin toplamı
			ViewBag.MessageListCount = _context.Messages.Where(x => x.İsRead == false).Count(); //Okunmamış mesajları toplamı
			ViewBag.MessagetotalCount = _context.Messages.Count(); //Okunmamış mesajları toplamı

			var values =_context.ToDoLists.Where(x=>x.Status == false).ToList();

			return View(values); 
		
		}
	}
}
