using System.Collections.Generic;
using System.Linq;
using OctoTenantApi.Interfaces;
using OctoTenantApi.Models;
using System.Threading.Tasks;

namespace OctoTenantApi.Services
{
    public class TenantService : ITenantService
    {
        private readonly TenantContext _dbContext;
        public TenantService(TenantContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Tenant item)
        {
            _dbContext.Tenants.Add(item);
            _dbContext.SaveChanges();
        }

        public async Task<List<Tenant>> ListAll()
        {
            return  await _dbContext.Tenants.ToAsyncEnumerable().ToList();
        }
    }
}