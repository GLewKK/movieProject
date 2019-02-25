using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieProject.ViewModels
{
    public class MovieFormatViewModel
    {
        [Required]
        [StringLength(30)]
        [Display(Name = "Format Type")]
        public string FormatType { get; set; }
    }
}