using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceHelper.Context;

namespace WebServiceHelper.Services
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public IAppContext _context { get; set; }
        public Repository(IAppContext context) => _context = context;

        public async Task Delete(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public Task<IList<T>> GetAll()
        {

        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
