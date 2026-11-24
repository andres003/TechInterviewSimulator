using Microsoft.AspNetCore.Mvc;

namespace InterviewSimulator.API.Controllers
{
    public class InterviewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
