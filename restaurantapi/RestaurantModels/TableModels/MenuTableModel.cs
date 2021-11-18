using System;
namespace RestaurantModels.TableModels
{
    public class MenuTableModel
    {
        #region Schema
        //CREATE TABLE MENU(
        //    RESTAURANT_ID INT NOT NULL,
        //    FOOD_ID INT NOT NULL,
        //    SEQUENCE INT,
        //    CONSTRAINT FK_MENU_RESTAURANT FOREIGN KEY (RESTAURANT_ID) REFERENCES RESTAURANT(ID),
        //    CONSTRAINT FK_MENU_FOOD FOREIGN KEY (FOOD_ID) REFERENCES FOOD(ID)
        //);
        #endregion
        public int Restaurant_ID { get; set; }
        public int Food_ID { get; set; }
        public int Sequence { get; set; }

        #region Foreign Key Tables
        public RestaurantTableModel Restaurant_IDFK { get; set; }
        public FoodTableModel Food_IDFK { get; set; }
        #endregion
    }
}
