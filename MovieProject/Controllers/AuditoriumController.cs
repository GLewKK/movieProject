using DAL.Models;
using MovieProject.ViewModels;
using System;
using System.Web.Mvc;

namespace MovieProject.Controllers
{
	public class AuditoriumController : Controller
	{
		private readonly ApplicationDbContext _context = new ApplicationDbContext();

		// GET: Auditorium
		public ActionResult Index()
		{
			var model = new AuditoriumViewModel();

			//var seats = UnitOfWork.Seats.GetAllSeats();
			return View(model);
		}

		[HttpPost]
		public ActionResult Index(AuditoriumViewModel model)
		{
			var auditorium = new Auditorium
			{
				Id = Guid.NewGuid(),
				Name = model.Name,
				SeatsNr = model.Width * model.Length
			};

			_context.Auditoriums.Add(auditorium);
			_context.SaveChanges();

			for (var i = 1; i <= model.Length; i++)
			{
				for (var j = 1; j <= model.Width; j++)
				{
					var seats = new Seat
					{
						Id = Guid.NewGuid(),
						Number = j,
						Row = i,
						AuditoriumId = auditorium.Id
					};

					_context.Seats.Add(seats);
					_context.SaveChanges();
				}
			}

			return View();
		}
	}
}