using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantModels.ResponseModels
{
    public class FoodModel
    {
        public string FoodId { get; set; }
        public string SubTitle { get; set; }
        public double Price { get; set; }
        public int Size { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> Picture { get; set;}
    }
}
