﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BgTracker_Assignment1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}