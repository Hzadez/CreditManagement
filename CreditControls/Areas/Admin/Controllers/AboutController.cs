using Microsoft.AspNetCore.Mvc;

namespace CreditControls.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
