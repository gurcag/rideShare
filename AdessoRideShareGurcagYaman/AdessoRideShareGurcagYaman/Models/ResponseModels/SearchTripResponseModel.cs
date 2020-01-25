using AdessoRideShareGurcagYaman.DataAccessLayer.Entities;
using System.Collections.Generic;

namespace AdessoRideShareGurcagYaman.Models.ResponseModels
{
    public class SearchTripResponseModel
    {
        public ICollection<Trip> Trips { get; set; }
    }
}
