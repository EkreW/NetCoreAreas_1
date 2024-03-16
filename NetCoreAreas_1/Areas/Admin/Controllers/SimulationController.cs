using Microsoft.AspNetCore.Mvc;

namespace NetCoreAreas_1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SimulationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
