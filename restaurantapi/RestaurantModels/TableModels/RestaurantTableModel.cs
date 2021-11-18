using System;
namespace RestaurantModels.TableModels
{
    public class RestaurantTableModel
    {
		#region Schema
		//CREATE TABLE RESTAURANT(
		//	ID INT PRIMARY KEY NOT NULL AUTO_INCREMENT ,
		//	RESTAURANT_ID VARCHAR (10) NOT NULL,
		//	RESTAURANT_NAME VARCHAR(45) NOT NULL,
		//	RESTAURANT_PHONE VARCHAR(45),
		//	RESTAURANT_ADDRESS VARCHAR(100), 
		//	RESTAURANT_VISIBILITY INT NOT NULL,
		//	CONSTRAINT RESTAURANT_ID_UNIQUE UNIQUE(RESTAURANT_ID)
		//);
		#endregion
		public int IDRestaurant { get; set; }
		public string Restaurant_ID { get; set; }
		public string Restaurant_Name { get; set; }
		public string Restaurant_Phone { get; set; }
		public string Restaurant_Address { get; set; }
		public int Restaurant_Visibility { get; set; }
    }
}
