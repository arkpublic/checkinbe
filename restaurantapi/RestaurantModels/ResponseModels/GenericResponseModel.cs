using RestaurantModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantModels.ResponseModels
{
    public class GenericResponseModel
    {
        public EnumResponseType ResponseType { get; set; }
        public string Message { get; set; }
        public object Object { get; set; }
    }
}
