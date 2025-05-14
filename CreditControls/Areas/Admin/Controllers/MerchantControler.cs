using Microsoft.AspNetCore.Mvc;

namespace CreditControls.Areas.Admin.Controllers
{
    public class MerchantControler : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
