using AdessoRideShareGurcagYaman.DataAccessLayer.Entities;
using System.Collections.Generic;

namespace AdessoRideShareGurcagYaman.DataAccessLayer.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        IEnumerable<T> List();
        T Get(long Id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(long Id);
    }
}
