using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieProject.ViewModels
{
    public class AuditoriumViewModel
    {
        [Required]
        [StringLength(30)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Seats Number")]
        public string SeatsNr { get; set; }

        [Required]
        [Display(Name = "Length")]
        public int Length { get; set; }

        [Required]
        [Display(Name = "Width")]
        public int Width { get; set; }
    }
}