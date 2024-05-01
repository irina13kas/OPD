using Microsoft.AspNetCore.Mvc;

namespace EstateAgentSite.Controllers
{
    public class CasesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
