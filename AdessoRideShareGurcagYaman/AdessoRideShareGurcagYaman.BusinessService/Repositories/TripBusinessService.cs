using AdessoRideShareGurcagYaman.BusinessService.Interfaces;
using AdessoRideShareGurcagYaman.DataAccessLayer.Entities;
using AdessoRideShareGurcagYaman.DataAccessLayer.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace AdessoRideShareGurcagYaman.BusinessService.Repositories
{
    public class TripBusinessService : ITripBusinessService
    {
        protected IGenericRepository<Trip> TripRepository { get; set; }

        public TripBusinessService(IGenericRepository<Trip> tripRepository)
        {
            this.TripRepository = tripRepository;
        }

        public ICollection<Trip> Search(Location startingLocation, Location finishingLocation)
        {
            List<Trip> trips = new List<Trip>();

            var tripList = this.TripRepository.List()
                        .Where(x => x.IsActive == true
                        && x.StartingLocation.Latitude == startingLocation.Latitude && x.StartingLocation.Longitude == startingLocation.Longitude
                        && x.FinishingLocation.Latitude == finishingLocation.Latitude && x.FinishingLocation.Longitude == finishingLocation.Longitude);

            return trips;
        }
    }
}
