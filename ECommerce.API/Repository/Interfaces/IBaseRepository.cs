using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.API.Repository.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> Create(T obj);
        Task<T> Update(T obj);
        Task<bool> Remove(Guid id);
        Task<T> GetById(Guid id);
        Task<IEnumerable<T>> GetAll();

    }
}
