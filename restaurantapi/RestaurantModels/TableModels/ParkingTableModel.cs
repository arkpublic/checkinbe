using System;
namespace RestaurantModels.TableModels
{
    public class ParkingTableModel
    {
        #region Schema
        //CREATE TABLE PARKING(
        //    ID INT PRIMARY KEY  NOT NULL AUTO_INCREMENT,
        //    PARKING_PLACES_ID INT (45) NOT NULL,
        //    PARKING_ADDRESS VARCHAR(45) NOT NULL
        //);
        #endregion
        public int IDParking { get; set; }
        public int Parking_Places_ID { get; set; }
        public string Parking_Address { get; set; }
    }
}
