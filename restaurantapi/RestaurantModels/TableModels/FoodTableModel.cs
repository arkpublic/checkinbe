using System;
namespace RestaurantModels.TableModels
{
    public class FoodTableModel
    {
		#region Schema
		//CREATE TABLE FOOD(
		//	ID INT PRIMARY KEY  NOT NULL AUTO_INCREMENT,
		//	FOOD_ID VARCHAR (45) NOT NULL,
		//	FOOD_SUBTITLE VARCHAR(45) NOT NULL,
		//  FOOD_PRICE FLOAT NOT NULL,
		//	FOOD_SIZE INT(12) NOT NULL,
		//	FOOD_VISIBILITY INT NOT NULL,
		//	CONSTRAINT FOOD_ID_UNIQUE UNIQUE(FOOD_ID)
		//);
		#endregion
		public int IDFood { get; set; }
		public string Food_ID { get; set; }
		public string Food_Subtitle { get; set; }
		public float Food_Price { get; set; }
		public int Food_Size { get; set; }
		public int Food_Visibility { get; set; }
    }
}
