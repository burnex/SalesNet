using System;
using SalesNet.Shared.Entities;
namespace SalesNet.Server.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task SeedAsync()
        {
            /*Update-DataBase*/
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
        }

        private async Task CheckCountriesAsync()
        {
            /*Si no existen Paises*/
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Country { Name = "Colombia" });
                _context.Countries.Add(new Country { Name = "Perú" });
                _context.Countries.Add(new Country { Name = "Mexico" });
                _context.Countries.Add(new Country { Name = "Brasil" });
                await _context.SaveChangesAsync();
            }
        }
    }
}