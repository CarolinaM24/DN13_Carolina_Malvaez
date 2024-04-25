using Microsoft.AspNetCore.Mvc;

namespace GymManaNgerC.Web.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}
