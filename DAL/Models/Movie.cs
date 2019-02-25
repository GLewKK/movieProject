using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Movie
    {
        public Guid Id { get; set; }

        public MovieImage MovieImage { get; set; }
        public Guid MovieImageId { get; set; }

        public string Name { get; set; }

        public string TrailerLink { get; set; }

        public DateTime PremiereDate { get; set; }

        public MovieFormat MovieFormat { get; set; }
        public Guid MovieFormatId { get; set; }

        //public MovieType MovieType { get; set; }
        //public Guid MovieTypeId { get; set; }

        public int Lenght { get; set; }

        public Clasification Clasification { get; set; }
        public Guid ClasificationId { get; set; }

        public string Description { get; set; }
    }

}
