using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
	public class ProjectsViewComponent : ViewComponent
	{
		public IViewComponentResult invoke()
		{
			return View("_Projects");
		}
	}
}
