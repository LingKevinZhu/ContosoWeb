﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        public DateTime HireDate { get; set; }
        public People People { get; set; }
    }
}
