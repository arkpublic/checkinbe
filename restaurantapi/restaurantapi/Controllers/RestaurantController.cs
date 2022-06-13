using Microsoft.AspNetCore.Mvc;
using RestaurantModels.Enums;
using RestaurantModels.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurantapi.Controllers
{
    [ApiController]
    [Route("restaurant")]
    public class RestaurantController : ControllerBase
    {
        [HttpGet("allrestaurants")]
        public GenericResponseModel GetRestaurants()
        {
            return new GenericResponseModel()
            {
                Message = "Success",
                ResponseType = EnumResponseType.success,
                Object = new List<RestaurantModel>() {
                    new RestaurantModel() {
                        Address = "Calle rio",
                        Comments = new List<CommentsModel>() {
                            new CommentsModel() {
                                Comment = "comments testing",
                                Date = "12/12/12",
                                Name = "JSS"
                            },
                            new CommentsModel() {
                                Comment = "comments testing",
                                Date = "12/12/12",
                                Name = "Marco"
                            },
                            new CommentsModel() {
                                Comment = "comments testing",
                                Date = "12/12/12",
                                Name = "Hector"
                            }

                        },
                        Name = "McDonals",
                        Parking = new ParkingModel() {
                            Address = "Rio",
                            Places = new ParkingPlacesModel() {
                                Available = false,
                                Location = "Here"
                            }
                        },
                        Phone = "12345879",
                        SocialMedia = new List<SocialMediaModel>() {
                            new SocialMediaModel() {
                                IsActive = true,
                                SocialMedia = EnumSocialMediaTypes.Facebook,
                                SocialMediaURL = "fb.com/gemineses"
                            }
                        }
                    }
                }
            };
        }

        [HttpGet("restaurant")]
        public GenericResponseModel GetRestaurant()
        {
            return new GenericResponseModel()
            {
                Message = "Success",
                ResponseType = EnumResponseType.success,
                Object = new RestaurantModel() { 
                    Address = "Calle rio",
                    Comments = new List<CommentsModel>() { 
                        new CommentsModel(){ 
                            Comment = "comments testing",
                            Date = "12/12/12",
                            Name = "JSS"
                        },
                        new CommentsModel(){
                            Comment = "comments testing",
                            Date = "12/12/12",
                            Name = "Marco"
                        },
                        new CommentsModel(){
                            Comment = "comments testing",
                            Date = "12/12/12",
                            Name = "Hector"
                        }

                    },
                    Name = "McDonals",
                    Parking = new ParkingModel() { 
                        Address = "Rio",
                        Places = new ParkingPlacesModel() { 
                            Available = false,
                            Location = "Here"
                        }
                    },
                    Phone = "12345879",
                    SocialMedia = new List<SocialMediaModel>() { 
                        new SocialMediaModel(){ 
                            IsActive = true,
                            SocialMedia = EnumSocialMediaTypes.Facebook,
                            SocialMediaURL = "fb.com/gemineses"
                        }
                    }
                }
            };
        }
    }
}
