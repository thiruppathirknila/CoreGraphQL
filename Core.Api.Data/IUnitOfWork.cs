using Core.Api.Data.Interfaces;
using System;
using System.Threading.Tasks;

namespace Core.Api.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IStoreRepository responseCode { get; }
        Task<int> Complete();
    }
}
