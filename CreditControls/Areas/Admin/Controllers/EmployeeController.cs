using Microsoft.AspNetCore.Mvc;

namespace CreditControls.Areas.Admin.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
