using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Models;
using SelectListItem = System.Web.WebPages.Html.SelectListItem;

namespace MovieProject.ViewModels
{
    public class MovieViewModel
    {
                
        public string Name { get; set; }

        public string TrailerLink { get; set; }

        
        public DateTime PremiereDate { get; set; }

        public string MovieFormat { get; set; }
        
        public string MovieType { get; set; }
         
        public int Lenght_min { get; set; }

	    public List<Clasification> Clasification { get; set; }
	    [Display(Name = "Clasification")]
	    public Guid ClasificationId { get; set; }

		public List<MovieFormat> MovieFormats { get; set; }

	    [Display(Name = "Format")]
		public Guid MovieFormatId { get; set; }


		public string Description { get; set; }

        public HttpPostedFileBase File { get; set; }
    }
}