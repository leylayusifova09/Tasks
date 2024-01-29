using Microsoft.AspNetCore.Mvc;
using Pageination.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        TestContext db = new TestContext();
        public IActionResult Telebe()
        {
            ViewBag.Telebe = db.Telebes.ToList();
            //int a = 0;
            //int b = 0;
            //int c = 0;
            //var list = db.Telebes.ToList();
            //a = list.Count / 10; 
            //b = a - 1; 
            //c = b - 1; 
            return View();
        }
        public IActionResult getTelebe(int Id)
        {

            int a = 0;
            int b = 0;
            var list = db.Telebes.ToList();
            a = (Id - 1) * 10 + 1;
            b = 10 * Id;
            //list = db.Telebes.Where(x => x.Sira <= b && x.Sira >= a).ToList();
            list = db.Telebes.Skip((Id-1)*10).Take(10).ToList();
            return Json(list);
        }
    }
}




