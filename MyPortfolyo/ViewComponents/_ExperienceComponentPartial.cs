using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;

namespace MyPortfolyo.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        MyPortfolioContext _context= new MyPortfolioContext();
        public IViewComponentResult Invoke() 
        {

            var values=_context.Experinces.ToList();

            return View(values); 
        }
    }
}
