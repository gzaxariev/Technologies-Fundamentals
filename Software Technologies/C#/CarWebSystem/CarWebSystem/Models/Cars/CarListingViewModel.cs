using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWebSystem.Models.Cars
{
    public class CarListingViewModel
    {
        public int Id { get; set; }
        public string Make { get; set; }

        public string Model { get; set; }

        public string ImageUrl { get; set; }

    }
}
