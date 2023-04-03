using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            //Viewdan id gelir-tag-helpers  vasitesi ile
            //ViewBag.id = id;
            return View();
        }
    }
}
