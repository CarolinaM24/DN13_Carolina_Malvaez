using Microsoft.AspNetCore.Mvc;

namespace GymManaNger.Web.Controllers
{
    
    public class AttendanceController : Controller
    {
        [Route("Attendance/Index")]
        public IActionResult Index()
        {
           //return RedirectToAction("MemberIn");
           return View();           
        }
        [Route("Attendance/MemberIn")]
        public IActionResult MemberIn()
        {
            return View();
        }
        [Route("Attendance/MemberOut")]
        public IActionResult MemberOut()
        {
            return View();
        }
    }
}
