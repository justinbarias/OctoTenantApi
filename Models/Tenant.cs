namespace OctoTenantApi.Models
{
    public class Tenant
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string CustomerCode { get; set; }
        
        public string DnsName { get; set; }
        
        public string SubscriptionCode { get; set; }
    }
}