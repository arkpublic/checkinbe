using System;
namespace RestaurantModels.TableModels
{
    public class CommentsTableModel
    {
        #region schema
        //CREATE TABLE COMMENTS(
        //    ID INT PRIMARY KEY  NOT NULL AUTO_INCREMENT,
        //    COMMENTS VARCHAR (250) NOT NULL,
        //    COMMENTS_DATE VARCHAR(45) NOT NULL,
        //    COMMENTS_NAME VARCHAR(45) NOT NULL
        //);
        #endregion
        public int IDComments { get; set; }
        public string Comments { get; set; }
        public DateTime Comments_Date { get; set; }
        public string Comments_Name { get; set; }
    }
}
