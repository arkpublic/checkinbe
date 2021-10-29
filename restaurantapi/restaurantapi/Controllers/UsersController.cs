using Microsoft.AspNetCore.Mvc;
using RestaurantModels.Builders;
using RestaurantModels.Enums;
using RestaurantModels.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurantapi.Controllers
{
    [ApiController]
    [Route("users")]
    public class UsersController:ControllerBase
    {
        [HttpGet]

        public GenericResponseModel GetUsers()
        {
            return new GenericResponseModel() {
                Message = "Success",
                ResponseType = EnumResponseTypes.Success,
                ResponseObject = new UsersModel () {
                    IdUser = "1",
                    Name = "Juan",
                    Phone = "664 123 44 55",
                    Photo = "img/001",
                    Tastes = new List<string>() { "#Salado", "#Mariscos" },
                    Geolocation = new GeolocationModel() {x = 1000.252, y= 121.252},
                    Notification = true,
                    SocialMedia = new SocialMediaModel() {SocialMedia = 0, IsActive = true},
                }

            };
        
        }

    }
}
