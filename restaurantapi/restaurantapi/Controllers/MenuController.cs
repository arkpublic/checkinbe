using Microsoft.AspNetCore.Mvc;
using RestaurantModels.Enums;
using RestaurantModels.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurantapi.Controllers
{
    [ApiController]
    [Route("menu")]
    public class MenuController : ControllerBase
    {
        [HttpGet("food")]
        public GenericResponseModel GetFood()
        {
            return new GenericResponseModel() {
                Message = "Success",
                ResponseType = EnumResponseType.success,
                Object = new FoodModel() {
                    FoodId = "a113",
                    Ingredients = new List<string>() { "Carne molida suprema", "tomate", "papa", "zanahoria" },
                    Picture = new List<string>() { "img" },
                    Price = 99.99,
                    Size = 5,
                    SubTitle = "Un delicisioso platillo servido con..."
                }
            };
        }

        [HttpGet ("menu")]
        public GenericResponseModel GetMenu() 
        {
            return new GenericResponseModel()
            {
                Message = "Success,",
                ResponseType = EnumResponseType.success,
                Object = new MenuModel() {
                    Dishes = new List<FoodModel>(){},
                    FoodType = EnumFoodType.Comida
                    
                }
            };
        
        }
    }
}
