using BLL.UnitOfWork;
using DAL.Models;
using MovieProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieProject.Controllers
{
    public class MovieImageController : Controller
    {
        public IUnitOfWork unitOfWork;
        public ApplicationDbContext _context = new ApplicationDbContext();
        // GET: MovieImage
        public ActionResult Index()
        {
            var model = new MovieImageViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(MovieImageViewModel model)
        {
            var img = Image.FromStream(model.File.InputStream, true, true);

         
                var filename = Path.GetFileName(model.File.FileName);

                var path = Path.Combine(Server.MapPath("~/Content/Photo/"), filename);

                model.File.SaveAs(path);
            MovieImage movie = new MovieImage
            {
                Id = Guid.NewGuid(),
                ImgName = filename,
                ImgPath = path,
                Lenght = img.Height,
                Width = img.Width
            };
            //unitOfWork.MovieImages.Add(movie);
            _context.MovieImages.Add(movie);
            _context.SaveChanges();
            //unitOfWork.Complete();

            return View();
        }
    }
}