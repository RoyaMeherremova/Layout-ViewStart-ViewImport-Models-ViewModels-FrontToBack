
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
      

        public IActionResult Index()
        {
            return View();
        }

       

    }
}