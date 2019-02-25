using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieProject.ViewModels
{
    public class MovieTypeViewModel
    {
        [Required]
        [StringLength(30)]
        [Display(Name = "Movie Type")]
        public string MovieType { get; set; }
    }
}