using RestaurantModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantModels.Builders
{
    public class GenericResponseModel
    {
        public EnumResponseTypes ResponseType { get; set; }
        public Object ResponseObject { get; set; }
        public string Message { get; set; }
    }
}
