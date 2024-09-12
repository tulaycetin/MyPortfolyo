using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;
using MyPortfolyo.DAL.Entities;

namespace MyPortfolyo.Controllers
{
	public class MessageController : Controller
	{
		MyPortfolioContext _context=new MyPortfolioContext();
		public IActionResult Inbox()
		{
			var values = _context.Messages.ToList();

			return View(values);
		}
		public IActionResult ChangeReadToTrue(int Id)
		{
			var value=_context.Messages.Find(Id);
			value.İsRead = true;	
			_context.SaveChangesAsync();
			return RedirectToAction("Inbox");
		}
		public IActionResult ChangeReadToFalse(int Id)
		{
			var value = _context.Messages.Find(Id);
			value.İsRead = false;
			_context.SaveChangesAsync();
			return RedirectToAction("Inbox");
		}

		public ActionResult DeleteMessage(int Id)
		{
			var value = _context.Messages.Find(Id);
			_context.Messages.Remove(value);	
			_context.SaveChangesAsync();
			return RedirectToAction("Inbox");
		}

		public ActionResult MessageDetail(int Id)
		{
			var value = _context.Messages.Find(Id);
	       return View(value);
		}

		//[HttpPost]
		//public async Task<IActionResult> SendMessage(Message message)
		//{
		//	if (ModelState.IsValid)
		//	{
		//		message.SendDate = DateTime.Now;
		//		message.İsRead = false;
		//		_context.Messages.Add(message);
		//		await _context.SaveChangesAsync();
		//		return RedirectToAction("Index", "Default");
		//	}
		//	return View("Error");
		//}



	}
}
