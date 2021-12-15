using System;
namespace RestaurantModels.TableModels
{
    public class GeolocationTableModel
    {
        #region Schema
        //CREATE TABLE geolocation(
        //    geolocationX DOUBLE(30),
	    //    geolocationY DOUBLE(30),
        //);
        #endregion
        public double GeolocationX { get; set; }
        public double GeolocationY { get; set; }
    }
}
