using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantModels.ResponseModels
{
    public class ParkingModel
    {
        public string Address { get; set; }
        public ParkingPlacesModel Places { get; set; }
    }

    public class ParkingPlacesModel { 
        public string Location { get; set; }
        public bool Available { get; set; }
    }
}
