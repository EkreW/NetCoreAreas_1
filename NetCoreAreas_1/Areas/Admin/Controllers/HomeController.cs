using Microsoft.AspNetCore.Mvc;

namespace NetCoreAreas_1.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        //Area'lar Attribute olarak tanımlanmadan calıstırılamaz
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
