using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Api.Data.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly StoreDbContext _context;

        protected GenericRepository(StoreDbContext context)
        {
            _context = context;
        }

        public async Task<T> Get(int id)
        {
            try
            {
                return await _context.Set<T>().FindAsync(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            try
            {
                return await _context.Set<T>().Take(8000) .ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public void Add(T entity)
        {
            try
            {
                 _context.Set<T>().Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        //public async Task Delete(int id)

        public void Delete(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            try
            {
                var result= _context.Set<T>().Find(id);
                _context.Entry(result).State = EntityState.Detached;
                return result;
            }
                
                 
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
