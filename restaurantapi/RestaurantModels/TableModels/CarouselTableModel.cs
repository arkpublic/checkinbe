using System;
namespace RestaurantModels.TableModels
{
    public class CarouselTableModel
    {
        #region Schema
        //CREATE TABLE CAROUSEL(
        //    ID INT PRIMARY KEY  NOT NULL AUTO_INCREMENT ,
        //    CAROUSEL_ID INT NOT NULL,
        //    CAROUSEL_TITLE VARCHAR (45) NOT NULL,
        //    CAROUSEL_SUBTITLE VARCHAR(45) NOT NULL,
        //    CAROUSEL_VISIBILITY INT NOT NULL
        //);
        #endregion
        public int IDCarousel { get; set; }
        public int Carousel_ID { get; set; }
        public string Carousel_Title { get; set; }
        public string Carousel_Subtitle { get; set; }
        public int Carousel_Visibility { get; set; }
    }
}
