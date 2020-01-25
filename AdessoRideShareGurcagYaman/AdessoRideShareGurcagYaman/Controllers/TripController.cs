using AdessoRideShareGurcagYaman.BusinessService.Interfaces;
using AdessoRideShareGurcagYaman.Models.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace AdessoRideShareGurcagYaman.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripController : ControllerBase
    {
        protected ITripBusinessService TripBusinessService { get; set; }

        public TripController(ITripBusinessService tripBusinessService)
        {
            this.TripBusinessService = tripBusinessService;
        }

        [HttpPost]
        public ActionResult Search([FromBody] SearchTripRequestModel searchTripRequestModel)
        {
            this.TripBusinessService.Search(searchTripRequestModel.StartingLocation, searchTripRequestModel.FinishingLocation);

            return Ok();
        }
    }
}