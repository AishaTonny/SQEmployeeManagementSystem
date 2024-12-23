using Microsoft.AspNetCore.Mvc;

namespace EmployeeInfoApprovalSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
