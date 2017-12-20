using OctoTenantApi.Models;
using System;
using System.Linq;

namespace OctoTenantApi.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TenantContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Tenants.Any())
            {
                return;   // DB has been seeded
            }

            var tenants = new Tenant[]
            {
            new Tenant{FullName="Doctor Aged Care",CustomerCode="DAC",DnsName="dac.helix.medicaldirector.com",SubscriptionCode="MD"},
            };
            foreach (Tenant s in tenants)
            {
                context.Tenants.Add(s);
            }
            context.SaveChanges();

        }
    }
}