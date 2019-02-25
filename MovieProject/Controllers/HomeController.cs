using BLL.UnitOfWork;
using DAL.Models;
using MovieProject.ViewModels;
using System;
using System.Web.Mvc;

namespace MovieProject.Controllers
{
	public class HomeController : Controller
	{
		private readonly ApplicationDbContext _context = new ApplicationDbContext();
		public IUnitOfWork UnitOfWork;

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult CreateGenre()
		{
			var model = new GenresViewModel();
			return View(model);
		}

		[HttpPost]
		public ActionResult CreateGenre(GenresViewModel model)
		{
			if (model.Title != null)
			{
				var genre = new Genre
				{
					Id = Guid.NewGuid(),
					Title = model.Title
				};


				UnitOfWork.Genres.Add(genre);


				_context.Genres.Add(genre);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			return HttpNotFound();
		}

		public ActionResult Admin()
		{
			return View();
		}
	}
}