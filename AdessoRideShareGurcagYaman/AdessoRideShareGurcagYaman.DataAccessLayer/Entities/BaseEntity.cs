using System;

namespace AdessoRideShareGurcagYaman.DataAccessLayer.Entities
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public long CreatedUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public long LastModifiedUserId { get; set; }
    }
}
