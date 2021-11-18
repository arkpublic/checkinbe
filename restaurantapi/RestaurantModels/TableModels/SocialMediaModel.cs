using System;
namespace RestaurantModels.TableModels
{
    public class SocialMediaModel
    {
        #region Schema
        //CREATE TABLE SOCIAL_MEDIA(
        //    SOCIAL_MEDIA_ID INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
        //    SOCIAL_MEDIA int (5),
	    //    SOCIAL_MEDIA_ACTIVE TINYINT(1),
	    //    SOCIAL_MEDIA_URL VARCHAR(45)
        //);
        #endregion
        public int Social_Media_ID { get; set; }
        public int Social_Media { get; set; }
        // using byte as recommended equivalent of tinyint, bool possible
        public byte Social_Media_Active { get; set; }
        public string Social_Media_URL { get; set; }
    }
}