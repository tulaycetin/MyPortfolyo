using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;

namespace MyPortfolyo.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        MyPortfolioContext _context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            //Controllerdan view'e veri taşır. Tek bir veri alınacağı yapı
            ViewBag.aboutTitle= _context.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.abutSubDescription=_context.Abouts.Select(x=>x.SubDescription).FirstOrDefault();
            ViewBag.abutDetail=_context.Abouts.Select(x=>x.Details).FirstOrDefault();
          
            return View(); 
        
        }    

    }
}
