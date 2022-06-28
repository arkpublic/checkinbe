using Microsoft.AspNetCore.Mvc;
using RestaurantManager.Interfaces;
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
        private IUserServices _userServices;

        [HttpGet]
        public GenericResponseModel GetUsers()
        {
            return new GenericResponseModel() {
                Message = "Success",
                ResponseType = EnumResponseType.success,
                Object = new UsersModel () {
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

        /// <summary>
        /// Get user authentication status
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getUserType")]
        public async Task<GenericResponseModel> GetUserTypeAsync(string token) {
            return await _userServices.getUserAuthenticationStatus(token);
        }
    }
}
