using Microsoft.AspNetCore.Mvc;

namespace dotnetApp.Controllers
{
    public class ProductController : Controller
    {
        public String Index()
        {
            return "Hello World";
        }

        public ActionResult Anasayfa()
        {
            return View();
        }
    }
}