using Microsoft.AspNetCore.Mvc;

namespace GymManaNger.Web.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
