﻿using KennelCodePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelCodePattern.Models
{
    class StandardService : IStandardService
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        public decimal Price { get; set; }
    }
}
