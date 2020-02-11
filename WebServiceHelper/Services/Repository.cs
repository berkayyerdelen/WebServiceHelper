using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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
            await _context.SaveChangesAsync(CancellationToken.None);
        }

        public async Task<IList<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task Insert(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync(CancellationToken.None);
        }

        public async Task Update(int id, T entity)
        {
            var currentEntity = await _context.Set<T>().FindAsync(id);
            currentEntity = entity;
            await _context.SaveChangesAsync(CancellationToken.None);
        }

        public async Task<IQueryable<T>> GetList()
        {
            return await Task.Run(() => _context.Set<T>());
        }
    }
}
