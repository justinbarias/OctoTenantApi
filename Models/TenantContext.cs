using Microsoft.EntityFrameworkCore;

namespace OctoTenantApi.Models
{
    public class TenantContext : DbContext
    {
        public TenantContext(DbContextOptions<TenantContext> options)
            : base(options)
        {
        }

        public DbSet<Tenant> Tenants { get; set; }

    }
}