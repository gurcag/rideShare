using AdessoRideShareGurcagYaman.DataAccessLayer.Entities;

namespace AdessoRideShareGurcagYaman.Models.RequestModels
{
    public class SearchTripRequestModel
    {
        public Location StartingLocation { get; set; }
        public Location FinishingLocation { get; set; }
    }
}
