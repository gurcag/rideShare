using System.Collections.Generic;

namespace AdessoRideShareGurcagYaman.DataAccessLayer.Entities
{
    public abstract class BaseUser : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public IEnumerable<Trip> Trips { get; set; }
        // TODO : other props will be defined later
    }
}
