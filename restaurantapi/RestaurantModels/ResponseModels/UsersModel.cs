using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantModels.ResponseModels
{
    public class UsersModel
    {
        public string IdUser {get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Photo { get; set; }
        public List<string> Tastes { get; set; }
        public GeolocationModel Geolocation { get; set; }
        public bool Notification { get; set; }
        public SocialMediaModel SocialMedia { get; set; }

    }
}
