using System;
using AdessoRideShareGurcagYaman.BusinessService.Interfaces;
using AdessoRideShareGurcagYaman.DataAccessLayer.Entities;
using AdessoRideShareGurcagYaman.DataAccessLayer.Interfaces;

namespace AdessoRideShareGurcagYaman.BusinessService.Repositories
{
    public class PassengerBusinessService : IPassengerBusinessService
    {
        protected IGenericRepository<Passenger> PassengerRepository { get; set; }
        protected IGenericRepository<TripRequest> TripRequestRepository { get; set; }
        protected IGenericRepository<Trip> TripRepository { get; set; }
        protected IGenericRepository<Vehicle> VehicleRepository { get; set; }

        public PassengerBusinessService(IGenericRepository<Passenger> passengerRepository,
                                        IGenericRepository<TripRequest> tripRequestRepository,
                                        IGenericRepository<Trip> tripRepository,
                                        IGenericRepository<Vehicle> vehicleRepository)
        {
            this.PassengerRepository = passengerRepository;
            this.TripRequestRepository = TripRequestRepository;
            this.TripRepository = TripRepository;
            this.VehicleRepository = vehicleRepository;
        }

        public bool SendTripRequest(long tripRequestId, long passengerId)
        {
            var tripRequest = this.TripRequestRepository.Get(tripRequestId);

            var trip = this.TripRepository.Get(tripRequest.TripId);

            var vehicle = this.VehicleRepository.Get(trip.VehicleId);

            if (vehicle.ReservedSeatCount < vehicle.SeatCount)
            {
                tripRequest.Status = TripRequestStatus.Pending;
                tripRequest.ModifiedDate = DateTime.Now;
                tripRequest.LastModifiedUserId = passengerId;
                tripRequest.IsActive = true;

                this.TripRequestRepository.Insert(tripRequest);

                return true;
            }
            else
            {
                tripRequest.Status = TripRequestStatus.Rejected;
                tripRequest.IsActive = false;

                this.TripRequestRepository.Insert(tripRequest);

                return false;
            }
        }
    }
}
