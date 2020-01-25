using AdessoRideShareGurcagYaman.DataAccessLayer.Entities;

namespace AdessoRideShareGurcagYaman.BusinessService.Interfaces
{
    public interface IDriverBusinessService
    {
        void PublishTrip(Trip trip, long driverId);
        void DropTrip(long tripId, long driverId);
        void AcceptTripRequest(long tripRequestId, long driverId);
        void RejectTripRequest(long tripRequestId, long driverId);
    }
}
