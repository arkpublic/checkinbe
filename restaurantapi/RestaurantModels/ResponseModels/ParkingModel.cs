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

   
}
