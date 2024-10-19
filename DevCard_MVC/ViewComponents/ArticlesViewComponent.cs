using DevCard_MVC.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace DevCard_MVC.ViewComponents
{
	public class ArticlesViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var articles = new List<Article>
			{
				new Article(1, "آموزش ASP.NET CORE MVC", "کاملترین پکیج آموزش asp.net core mvc به زبان فارسی",
					"blog-post-thumb-card-1.jpg"),
				new Article(2, "آموزش Git & GitHub", "کاملترین پکیج آموزش Git & GitHub به زبان فارسی", "blog-post-thumb-card-2.jpg"),
				new Article(3, "آموزش onion arcitecture", "کامل ترین پکیج آموزشی onion arcitecture به زبان فارسی",
					"blog-post-thumb-card-3.jpg"),
				new Article(4, "آموزش طراحی وبسایت", "کاملترین پکیج آموزش طراحی وبسایت به زبان فارسی", "blog-post-thumb-card-4.jpg")
			};
			return View(articles);
		}
	}
}
