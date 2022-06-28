using RestaurantModels.ResponseModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Interfaces
{
    public interface IUserServices
    {
        Task<GenericResponseModel> getUserAuthenticationStatus(string token);
    }
}
