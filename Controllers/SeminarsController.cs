using Microsoft.AspNetCore.Mvc;

namespace EstateAgentSite.Controllers
{
	public class SeminarsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
