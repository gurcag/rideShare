using AdessoRideShareGurcagYaman.DataAccessLayer.Entities;

namespace AdessoRideShareGurcagYaman.Models.RequestModels
{
    public class SendTripRequestRequestModel
    {
        public long TripRequestId { get; set; }
        public long PassengerId { get; set; }
    }
}
