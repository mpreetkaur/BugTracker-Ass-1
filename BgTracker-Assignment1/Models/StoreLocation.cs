using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BgTracker_Assignment1.Models
{
    public class StoreLocation
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public ICollection<Sale> Sales { get; set; }

        public StoreLocation()
        {
            Sales = new List<Sale>();
        }
    }
}