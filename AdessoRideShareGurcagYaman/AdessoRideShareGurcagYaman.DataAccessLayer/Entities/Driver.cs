using System.Collections.Generic;

namespace AdessoRideShareGurcagYaman.DataAccessLayer.Entities
{
    public class Driver : BaseUser
    {
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
