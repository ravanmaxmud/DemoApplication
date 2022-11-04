using Microsoft.AspNetCore.Mvc;

namespace DemoAppp.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
             return View();
        }
    }
}
