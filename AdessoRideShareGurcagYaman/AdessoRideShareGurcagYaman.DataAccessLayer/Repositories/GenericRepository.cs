using System;
using System.Collections.Generic;
using AdessoRideShareGurcagYaman.DataAccessLayer.Entities;
using AdessoRideShareGurcagYaman.DataAccessLayer.Interfaces;

namespace AdessoRideShareGurcagYaman.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        public void Delete(long Id)
        {
            throw new NotImplementedException();
        }

        public T Get(long Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
