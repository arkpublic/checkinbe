using RestaurantModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantModels.ResponseModels
{
     public class SocialMediaModel
    {
        public EnumSocialMediaTypes SocialMedia{ get; set; }

        public Boolean IsActive { get; set;}
        public string SocialMediaURL { get; set; }
    }
}
