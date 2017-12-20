using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OctoTenantApi.Models;
using OctoTenantApi.Interfaces;

namespace OctoTenantApi.Controllers
{
    [Route("api/[controller]")]
    public class TenantController : Controller
    {
        private readonly ITenantService _tenantService;

        public TenantController(ITenantService tenantService)
        {
            _tenantService = tenantService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tenants = await _tenantService.ListAll();

            return new OkObjectResult(tenants);
        }

    }
}
