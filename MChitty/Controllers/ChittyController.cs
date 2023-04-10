using MChitty.Entity;
using MChitty.Entity.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web.Resource;

namespace MChitty.Controllers
{
    [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    [Authorize]
    [ApiController]
    public class ChittyController : ControllerBase
    {
        private readonly ILogger<ChittyController> _logger;
        private readonly MCDbContext _dbContext;

        public ChittyController(ILogger<ChittyController> logger, MCDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("chitty")]
        public IEnumerable<Chitty> Get()
        {
            return _dbContext.Chittys.ToList();
        }
    }
}