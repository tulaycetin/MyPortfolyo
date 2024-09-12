using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo.ViewComponents
{
    public class _YorumlarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() {return View(); }
    }
}
