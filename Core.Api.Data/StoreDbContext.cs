using Core.Api.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.Api.Data
{
    public class StoreDbContext: DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        { }
        public DbSet<ResponseCodes> ResponseCodes { get; set; }

    }
}
