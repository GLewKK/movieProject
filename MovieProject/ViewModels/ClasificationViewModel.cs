using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieProject.ViewModels
{
    public class ClasificationViewModel
    {
        [Required]
        [StringLength(30)]
        [Display(Name = "Title")]
        public string Title { get; set; }
    }
}