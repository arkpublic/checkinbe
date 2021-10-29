using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantModels.ResponseModels
{
    public class RestaurantModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public List<CommentsModel> Comments { get; set; }
        public List<SocialMediaModel> SocialMedia { get; set; }
        public ParkingModel Parking { get; set; }

        
    }
}
