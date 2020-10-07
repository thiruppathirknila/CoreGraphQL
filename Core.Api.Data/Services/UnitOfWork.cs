using Core.Api.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Api.Data.Repository;

namespace Core.Api.Data.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StoreDbContext _context;
        public IStoreRepository responseCode { get; }


        public UnitOfWork(StoreDbContext StoreDbContext)
        {
            this._context = StoreDbContext;
            this.responseCode = new StoreRepository(_context);
            
        }
        public async Task<int> Complete()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }

    }
}
