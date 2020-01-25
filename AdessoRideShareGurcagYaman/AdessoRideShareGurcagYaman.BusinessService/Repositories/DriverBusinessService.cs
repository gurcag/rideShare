using System;
using AdessoRideShareGurcagYaman.BusinessService.Interfaces;
using AdessoRideShareGurcagYaman.DataAccessLayer.Entities;
using AdessoRideShareGurcagYaman.DataAccessLayer.Interfaces;

namespace AdessoRideShareGurcagYaman.BusinessService.Repositories
{
    public class DriverBusinessService : IDriverBusinessService
    {
        protected IGenericRepository<Driver> DriverRepository { get; set; }
        protected IGenericRepository<Trip> TripRepository { get; set; }
        protected IGenericRepository<TripRequest> TripRequestRepository { get; set; }

        public DriverBusinessService(IGenericRepository<Driver> driverRepository,
                                    IGenericRepository<Trip> tripRepository,
                                    IGenericRepository<TripRequest> tripRequestRepository)
        {
            this.DriverRepository = driverRepository;
            this.TripRepository = tripRepository;
            this.TripRequestRepository = TripRequestRepository;
        }

        public void DropTrip(long tripId, long driverId)
        {
            var trip =  this.TripRepository.Get(tripId);

            trip.LastModifiedUserId = driverId;
            trip.ModifiedDate = DateTime.Now;
            trip.IsActive = false;

            this.TripRepository.Update(trip);
        }

        public void PublishTrip(Trip trip, long driverId)
        {
            trip.CreatedUserId = driverId;
            trip.CreationDate = DateTime.Now;
            trip.IsActive = true;

            this.TripRepository.Insert(trip);
        }

        public void AcceptTripRequest(long tripRequestId, long driverId)
        {
            var tripRequest = this.TripRequestRepository.Get(tripRequestId);

            tripRequest.LastModifiedUserId = driverId;
            tripRequest.Status = TripRequestStatus.Accepted;
            tripRequest.ModifiedDate = DateTime.Now;

            this.TripRequestRepository.Update(tripRequest);
        }

        public void RejectTripRequest(long tripRequestId, long driverId)
        {
            var tripRequest = this.TripRequestRepository.Get(tripRequestId);

            tripRequest.LastModifiedUserId = driverId;
            tripRequest.Status = TripRequestStatus.Rejected;
            tripRequest.ModifiedDate = DateTime.Now;

            this.TripRequestRepository.Update(tripRequest);
        }
    }
}
