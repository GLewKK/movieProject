﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Actor
    {
        public Guid Id { get; set; }
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public string  Link { get; set; }
    }
}