﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductWeb.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> employee { get; set; }

    }
}
