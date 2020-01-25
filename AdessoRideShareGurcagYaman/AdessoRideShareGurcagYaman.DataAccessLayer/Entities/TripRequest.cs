namespace AdessoRideShareGurcagYaman.DataAccessLayer.Entities
{
    public class TripRequest : BaseEntity
    {
        public TripRequestStatus Status { get; set; }
        public long TripId { get; set; }
    }
}
