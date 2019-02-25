using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieProject.ViewModels
{
    public class MovieImageViewModel
    {
        [Required]
        [StringLength(30)]
        [Display(Name = "Image Name")]
        public string ImgName { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Image Path")]
        public string ImgPath { get; set; }

        [Required]
        [Display(Name = "Width")]
        public int Width { get; set; }

        [Required]
        [Display(Name = "Lenght")]
        public int Lenght { get; set; }

        public HttpPostedFileBase File { get; set; }

    }

}