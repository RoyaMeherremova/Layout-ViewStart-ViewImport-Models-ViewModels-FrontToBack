using Layout_ViewModels.Models;
using Layout_ViewModels.ViewModels.Home;
using Layout_ViewModels.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;

namespace Layout_ViewModels.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            //string name = "Xacker";
            //return View((object)name); tek string gonderende ViewBag olmadan -objecte kast etmelisen.
            //1)ViewData-Viewa parametrkimi gondermeyende bucur gondermey olur. lakin onu viewda kast. elemey lazimdi ,sistem oxuya bilmir typeni.
            //ViewData["names"] = new string[] { "Elcan", "Aqsin", "Pervin" };


            //2)ViewBag-Viewa parametrkimi gondermeyende bucur gondermey olur,kast ehtiyac yoxdu type geyd edirik.
            //ViewBag.numbers = new int[] { 10, 20, 30 };    
            //ViewBag.name = "Elcan";


            //3)TempData-eyni controllerde olan basqa actiona data gondermek ucun
            //meselen data create olunur ve Datalar siyahisin gorsensin
            //TempData["surname"] = "Qurbanov";


            //RedirectToAction-method ile biz deafult olaraq action sece bilerik
            //return RedirectToAction(nameof(Detail));



            Student stu1 = new()
            {
                Id = 1,
                FullName = "Pervin Rehimli",
                Age = 26
            };
            Student stu2 = new()
            {
                Id = 2,
                FullName = "Ali Talibov",
                Age = 21
            };
            Student stu3 = new()
            {
                Id = 3,
                FullName = "Mirze Bashirli",
                Age = 27
            };

            List<Student> students = new List<Student> { stu1, stu2, stu3 };


            Product product = new()
            {
                Id = 1,
                Name = "Samsung 11",
                Count = 50,
                Price = 200,
                Description = "Description"
            };
            //ProductVM-productun mueyen datalarini gondermek  ucun hamsin gondermemek ucun istifade olunur
            ProductVM productVM = new()
            {
                Name = product.Name,
                Price = product.Price
            };
            //HomeVM-iki model gondermek ucun viewa 
            HomeVM model = new()
            {
                Students = students,
                Product = productVM
            };
            return View(model);
        }
        //public IActionResult Detail()
        //{

        //    return View();

        //}

    }
}
