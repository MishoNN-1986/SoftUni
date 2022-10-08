using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalogue
{
    class Catalogue
    {
        public Catalogue()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}
