using AutoMapper;
using MChitty.DTO;
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
        private IMapper _mapper;

        public ChittyController(ILogger<ChittyController> logger, MCDbContext dbContext, IMapper mapper)
        {
            _logger = logger;
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("chitty")]
        public async Task<IEnumerable<ChittyDto>> Get()
        {
            return _mapper.Map<List<ChittyDto>>(_dbContext.Chittys.ToList());
        }

        [HttpPost]
        [Route("chitty")]
        public async Task  Save(ChittyDto chittyDto)
        {
            var chitties = _mapper.Map<Chitty>(chittyDto);
            await _dbContext.Chittys.AddAsync(chitties);
            await _dbContext.SaveChangesAsync();
        }

        [HttpPut]
        [Route("chitty")]
        public async Task Update(ChittyDto chittyDto)
        {
            var chitties = _mapper.Map<Chitty>(chittyDto);
            _dbContext.Chittys.Update(chitties);
            await _dbContext.SaveChangesAsync();
        }
    }
}