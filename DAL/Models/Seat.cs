using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Seat
    {
        public Guid Id { get; set; }
        public int Row { get; set; }
        public int Number { get; set; }
        public Auditorium Auditorium { get; set; }
        public Guid AuditoriumId { get; set; }

    }
}
