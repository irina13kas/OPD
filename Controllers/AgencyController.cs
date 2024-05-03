using Microsoft.AspNetCore.Mvc;

namespace EstateAgentSite.Controllers
{
	public class AgencyController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
