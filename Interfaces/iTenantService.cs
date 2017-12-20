using System.Collections.Generic;
using OctoTenantApi.Models;
using System.Threading.Tasks;

namespace OctoTenantApi.Interfaces
{
    public interface ITenantService
    {
        Task<List<Tenant>> ListAll();
        void Add(Tenant character);
    }
}