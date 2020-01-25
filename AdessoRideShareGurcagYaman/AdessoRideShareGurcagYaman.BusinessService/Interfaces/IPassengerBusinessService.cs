using AdessoRideShareGurcagYaman.DataAccessLayer.Entities;

namespace AdessoRideShareGurcagYaman.BusinessService.Interfaces
{
    public interface IPassengerBusinessService
    {
        bool SendTripRequest(long tripRequestId, long passengerId);
    }
}
