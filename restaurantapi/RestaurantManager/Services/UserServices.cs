using RestaurantManager.Interfaces;
using RestaurantModels.ResponseModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Services
{
    public class UserServices : IUserServices
    {
        public Task<GenericResponseModel> getUserAuthenticationStatus(string token)
        {
            //Ask To Database
            //If existst
            //If Token is active
            //Renewal token
            //If token is not active
            //Ask for authenticate

            throw new NotImplementedException();
        }
    }
}
