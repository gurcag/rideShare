using AdessoRideShareGurcagYaman.DataAccessLayer.Entities;
using System.Collections.Generic;

namespace AdessoRideShareGurcagYaman.BusinessService.Interfaces
{
    public interface ITripBusinessService
    {
        ICollection<Trip> Search(Location startingLocation, Location finishingLocation);
    }
}
