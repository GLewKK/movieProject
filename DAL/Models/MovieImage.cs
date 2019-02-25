using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class MovieImage
    {
        public Guid Id { get; set; }
        public string ImgName { get; set; }
        public string ImgPath { get; set; }
        public int Width { get; set; }
        public int Lenght { get; set; }

    }
}
