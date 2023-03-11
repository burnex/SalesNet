using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesNet.Server.Data;
using SalesNet.Shared.Entities;

namespace SalesNet.Server.Controllers
{
    [ApiController]
    [Route("/api/countries")]
    public class CountriesController : ControllerBase
    {
        public readonly DataContext _context;

        public CountriesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            return Ok(await _context.Countries.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync(Country country)
        {
            _context.Add(country);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}

