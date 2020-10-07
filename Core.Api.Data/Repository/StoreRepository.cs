using Core.Api.Data.Interfaces;
using Core.Api.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Api.Data.Repository
{
    public class StoreRepository: GenericRepository<ResponseCodes>, IStoreRepository
    {
        public StoreRepository(StoreDbContext context) : base(context)
        {

        }

    }
}
