using Microsoft.AspNetCore.Mvc;

namespace EstateAgentSite.Controllers
{
	public class ContactsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
