using Microsoft.AspNetCore.Mvc;

namespace dotnetApp.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}