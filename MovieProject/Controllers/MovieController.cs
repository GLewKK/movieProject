using DAL.Models;
using MovieProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieProject.Controllers
{
    public class MovieController : Controller

    {
	    private readonly ApplicationDbContext _context = new ApplicationDbContext();
        // GET: Movie
        public ActionResult Index()
        {
	        var result = _context.Movies.Include(a => a.Clasification).Include(x => x.MovieFormat)
		        .Include(q => q.MovieImage).ToList();
            return View(result);
        }
        public ActionResult Create()
        {
            var movie = new  MovieViewModel();

	        var clasifications = _context.Clasifications.ToList();
	        var formats = _context.MovieFormats.ToList();

	        movie.Clasification = clasifications;
	        movie.MovieFormats = formats;

            return View(movie);
        }

        [HttpPost]
        public ActionResult Create(MovieViewModel model)
        {
            var movie = new Movie();
            var img = Image.FromStream(model.File.InputStream, true, true);


            var filename = Path.GetFileName(model.File.FileName);

	        if (filename != null)
	        {
		        var path = Path.Combine(Server.MapPath("~/Content/Photo/"), filename);

		        model.File.SaveAs(path);
		        var movieImg = new MovieImage
		        {
			        Id = Guid.NewGuid(),
			        ImgName = filename,
			        ImgPath = path,
			        Lenght = img.Height,
			        Width = img.Width
		        };
		        _context.MovieImages.Add(movieImg);
		        _context.SaveChanges();

		        movie.Id = Guid.NewGuid();
		        movie.Name = model.Name;
		        movie.TrailerLink = model.TrailerLink;
		        movie.PremiereDate = model.PremiereDate;
		        movie.Lenght = model.Lenght_min;
		        movie.Description = model.Description;
		        movie.MovieImageId = movieImg.Id;
		        movie.ClasificationId = model.ClasificationId;
		        movie.MovieFormatId = model.MovieFormatId;
	        }


	        _context.Movies.Add(movie);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
    
}