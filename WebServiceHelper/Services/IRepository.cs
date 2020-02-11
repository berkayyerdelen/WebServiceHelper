using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceHelper.Entities.Domains;

namespace WebServiceHelper.Services
{
    public interface IRepository<T>
    {
        Task<IList<T>> GetAll();
        Task<T> GetById(int id);
        Task Delete(int id);
        Task Update(int id, T entity);
        Task Insert(T entity);
    }
}
