using System;

namespace AdessoRideShareGurcagYaman.DataAccessLayer.Entities
{
    public class Trip : BaseEntity
    {
        public long VehicleId { get; set; }
        /// <summary>
        /// When a trip actually goes on
        /// </summary>
        public DateTime TripDate { get; set; }
        public string Description { get; set; }
        public Location StartingLocation { get; set; }
        public Location FinishingLocation { get; set; }
        // TODO : other props will be defined later
    }
}
