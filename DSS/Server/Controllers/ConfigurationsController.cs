using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DSS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationsController : ControllerBase
    {
        private readonly DataContext _context;
        public ConfigurationsController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Configuration>>> GetConfigurations()
        {
            return Ok(await _context.Configurations.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Configuration>> GetConfigurationById(int id)
        {
            return Ok(await _context.Configurations.FindAsync(id));
        }
        
        [HttpGet("{name}")]
        public async Task<ActionResult<Configuration>> GetConfigurationByName(string name)
        {
            return Ok(await _context.Configurations.FirstOrDefaultAsync(c => c.Name == name));
        }

        [HttpPost]
        public async Task<ActionResult<Configuration>> CreateConfiguration(Configuration configuration)
        {
            _context.Configurations.Add(configuration);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Configuration>> UpdateConfiguration(Configuration configuration)
        {
            var dbConfiguration = await _context.Configurations.FirstOrDefaultAsync(c => c.Id == configuration.Id);
            if (dbConfiguration == null)
            {
                return NotFound("Configuration not found");
            }
            dbConfiguration.Carriers = configuration.Carriers; 
            dbConfiguration.Name = configuration.Name;
            dbConfiguration.Client = configuration.Client;

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteConfiguration(int id)
        {
            var dbConfiguration = await _context.Configurations.FindAsync(id);
            if (dbConfiguration == null)
            {
                return NotFound("Configuration not found");
            }
            _context.Configurations.Remove(dbConfiguration);
            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}
