using DAL.Models;
using MovieProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieProject.Controllers
{
    public class ActorController : Controller
    {
        public readonly ApplicationDbContext _context = new ApplicationDbContext();
        // GET: Actor
        public ActionResult Index()
        {
            var model = new ActorViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(ActorViewModel model)
        {
            if (model != null)
            {
                var actor = new Actor();

                actor.Id = Guid.NewGuid();
                actor.FirstName = model.FirstName;
                actor.LastName = model.LastName;
                actor.Link = model.Link;

                _context.Actors.Add(actor);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return HttpNotFound();
        }
    }
}