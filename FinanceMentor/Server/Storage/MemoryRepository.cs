using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceMentor.Server.Storage
{
    public class MemoryRepository<T> : IRepository<T>
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
