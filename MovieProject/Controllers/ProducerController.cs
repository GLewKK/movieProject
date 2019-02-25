using DAL.Models;
using MovieProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieProject.Controllers
{
    public class ProducerController : Controller
    {
        public readonly ApplicationDbContext _context = new ApplicationDbContext();
        // GET: Producer
        public ActionResult Index()
        {
            var model = new ProducerViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(ProducerViewModel model)
        {
            if (model != null)
            {
                var producer = new Producer();

                producer.Id = Guid.NewGuid();
                producer.FirstName = model.FirstName;
                producer.LastName = model.LastName;
                producer.Link = model.Link;

                _context.Producers.Add(producer);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return HttpNotFound();
        }
    }
}