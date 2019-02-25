using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieProject.ViewModels
{
    public class ActorViewModel
    {
        [Required]
        [StringLength(30)]
        [Display(Name = "First Name")]
        public string FirstName  { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Last Name")]
        public string LastName   { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "IMDb Link")]
        public string Link       { get; set; }
    }
}