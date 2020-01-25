using AdessoRideShareGurcagYaman.BusinessService.Interfaces;
using AdessoRideShareGurcagYaman.Models.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace AdessoRideShareGurcagYaman.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        protected IPassengerBusinessService PassengerBusinessService { get; set; }

        public PassengerController(IPassengerBusinessService passengerBusinessService)
        {
            this.PassengerBusinessService = passengerBusinessService;
        }

        [HttpPost]
        public ActionResult SendTripRequest([FromBody] SendTripRequestRequestModel sendTripRequestRequestModel)
        {
            this.PassengerBusinessService.SendTripRequest(sendTripRequestRequestModel.TripRequestId, sendTripRequestRequestModel.PassengerId);

            return Ok();
        }
    }
}