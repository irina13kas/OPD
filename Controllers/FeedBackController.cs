using Microsoft.AspNetCore.Mvc;

namespace EstateAgentSite.Controllers
{
    public class FeedBackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
