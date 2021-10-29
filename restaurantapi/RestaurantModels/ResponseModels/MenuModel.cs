using Microsoft.AspNetCore.Mvc;
using RestaurantModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantModels.ResponseModels
{
    public class MenuModel
    {
        public List<FoodModel> Dishes { get; set; }
        public EnumFoodType FoodType { get; set; }

    }
}
