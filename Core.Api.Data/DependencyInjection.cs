using System;
using System.Collections.Generic;
using System.Text;
using Core.Api.Data.Interfaces;
using Core.Api.Data.Repository;
using Core.Api.Data.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Api.Data
{
    public static class DependencyInjection
    {
      
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IStoreRepository, StoreRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
