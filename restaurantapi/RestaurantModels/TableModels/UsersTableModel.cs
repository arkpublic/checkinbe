using System;
namespace RestaurantModels.TableModels
{
    public class UsersTableModel
    {
		#region Schema
		//CREATE TABLE USERS(
		//	ID INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
		//	ID_USER INT (45) NOT NULL,
		//	NAME_USER VARCHAR(45) NOT NULL,
		//	USER_PHONE VARCHAR(25) NOT NULL,
		//	USER_PHOTO VARCHAR(45) NOT NULL,
		//	USER_TASTES VARCHAR(255)NOT NULL,
		//	USER_NOTIFICATIONS TINYINT(1) NOT NULL,
		//	USER_VISIBILITY INT NOT NULL
		//);
        #endregion
		public int IDUsers { get; set; }
		public int User_ID { get; set; }
		public string User_Name { get; set; }
		public string User_Phone { get; set; }
		public string User_Tastes { get; set; }
		public bool User_Notifications { get; set; }
		public int User_Visibility { get; set; }
    }
}