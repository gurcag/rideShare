using Microsoft.AspNetCore.Mvc;
using AdessoRideShareGurcagYaman.BusinessService.Interfaces;
using AdessoRideShareGurcagYaman.DataAccessLayer.Entities;
using AdessoRideShareGurcagYaman.Models.RequestModels;

namespace AdessoRideShareGurcagYaman.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        protected IDriverBusinessService DriverBusinessService { get; set; }

        public DriverController(IDriverBusinessService driverBusinessService)
        {
            this.DriverBusinessService = driverBusinessService;
        }

        [HttpPost]
        public ActionResult PublishTrip([FromBody] PublishTripRequestModel publishTripRequestModel)
        {
            Trip trip = new Trip
            {
                Description = publishTripRequestModel.Trip.Description,
                FinishingLocation = publishTripRequestModel.Trip.FinishingLocation,
                StartingLocation = publishTripRequestModel.Trip.StartingLocation,
                TripDate = publishTripRequestModel.Trip.TripDate
            };

            this.DriverBusinessService.PublishTrip(trip, publishTripRequestModel.DriverId);

            return Ok();
        }

        [HttpPost]
        public ActionResult DropTrip([FromBody] DropTripRequestModel dropTripRequestModel)
        {
            this.DriverBusinessService.DropTrip(dropTripRequestModel.TripId, dropTripRequestModel.DriverId);

            return Ok();
        }

        [HttpPost]
        public ActionResult AcceptTripRequest([FromBody] AcceptTripRequestRequestModel acceptTripRequestRequestModel)
        {
            this.DriverBusinessService.AcceptTripRequest(acceptTripRequestRequestModel.TripId, acceptTripRequestRequestModel.DriverId);

            return Ok();
        }

        [HttpPost]
        public ActionResult RejectTripRequest([FromBody] RejectTripRequestRequestModel rejectTripRequestRequestModel)
        {
            this.DriverBusinessService.RejectTripRequest(rejectTripRequestRequestModel.TripId, rejectTripRequestRequestModel.DriverId);

            return Ok();
        }
    }
}