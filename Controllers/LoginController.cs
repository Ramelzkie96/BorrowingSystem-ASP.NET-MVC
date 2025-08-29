using Microsoft.AspNetCore.Mvc;
namespace BorrowingSystem.Controllers
{
    public class LoginController : Controller
    {
        // GET: /Login
        public IActionResult Index()
        {
            return View();  // looks for Views/Login/Index.cshtml
        }
    }
}
