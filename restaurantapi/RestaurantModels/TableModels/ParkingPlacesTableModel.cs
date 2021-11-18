using System;
namespace RestaurantModels.TableModels
{
    public class ParkingPlacesTableModel
    {
        #region Schema
     //   CREATE TABLE PARKING_PLACES(
     //       ID INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
     //       PARKING_PLACE_ID INT (45) NOT NULL,
     //       PARKING_LOCATION VARCHAR(45) NOT NULL,
     //       PARKING_AVAILABLE TINYINT(1) NOT NULL,
     //       CONSTRAINT FK_PLACES_PARKING FOREIGN KEY(PARKING_PLACE_ID) REFERENCES PARKING(ID)
	    //);
        #endregion
        public int IDParkingPlaces { get; set; }
        public int Parking_Place_ID { get; set; }
        public string Parking_Location { get; set; }
        // using byte as recommended equivalent of tinyint, bool possible
        public byte Parking_Available { get; set; }

        #region Foreign Key Tables
        public ParkingTableModel Parking_Place_IDFK { get; set; }
        #endregion
    }
}
