using AdessoRideShareGurcagYaman.DataAccessLayer.Entities;

namespace AdessoRideShareGurcagYaman.Models.RequestModels
{
    public class PublishTripRequestModel
    {
        public Trip Trip { get; set; }
        public long DriverId { get; set; }
    }
}
