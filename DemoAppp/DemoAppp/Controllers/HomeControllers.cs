using Microsoft.AspNetCore.Mvc;

namespace DemoAppp.Controllers
{
    public class HomeControllers : Controller
    {
        public ViewResult Index()
        {
             return View();
        }
    }
}
