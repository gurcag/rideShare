namespace AdessoRideShareGurcagYaman.DataAccessLayer.Entities
{
    public class Vehicle : BaseEntity
    {
        // how many seats are there except driver seat
        public int SeatCount { get; set; }
        public int ReservedSeatCount { get; set; }

        // TODO : other props will be defined later
    }
}
