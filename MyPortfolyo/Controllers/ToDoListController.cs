using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolyo.DAL.Context;
using MyPortfolyo.DAL.Entities;
using NuGet.Protocol;

namespace MyPortfolyo.Controllers
{
	public class ToDoListController : Controller
	{ MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			var values = context.ToDoLists.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateToDoList()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateToDoList(ToDoList toDoList)
		{
			toDoList.Status = false;
			context.ToDoLists.Add(toDoList);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult DeleteToDoList(int Id)
		{
			var value = context.ToDoLists.Find(Id);
			context.ToDoLists.Remove(value);
			context.SaveChanges();	
			return RedirectToAction("Index");
     		
		}
		[HttpGet]
		public IActionResult UpdateToDoList(int Id)
		{
			var value = context.ToDoLists.Find(Id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateToDoList(ToDoList toDoList)
		{
			context.ToDoLists.Update(toDoList);
			context.SaveChanges();	
			return RedirectToAction("Index");
		}
		public IActionResult ChangeStatusToTrue(int Id)
		{
			var value = context.ToDoLists.Find(Id);
			value.Status = true;
			context.SaveChangesAsync();
			return RedirectToAction("Index");
		}
		public IActionResult ChangeStatusToFalse(int Id)
		{
			var value = context.ToDoLists.Find(Id);
			value.Status = false;
			context.SaveChangesAsync();
			return RedirectToAction("Index");
		}
	}
}
