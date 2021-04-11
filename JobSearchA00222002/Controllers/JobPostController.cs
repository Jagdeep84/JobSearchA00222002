
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JobSearchA00222002.Controllers
{
    [AllowAnonymous]
    public class JobPostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
