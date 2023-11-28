using BasketApp.Domain.Entities;
using BasketApp.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Infrastructure.Seeders
{
    public class DivisionSeeder
    {
        private readonly BasketAppDbContext _dbContext;
        public DivisionSeeder(BasketAppDbContext dbContext)
        {

            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.Divisions.Any())
                {
                    var divisionsData = new List<Division>
                    {
                        new Division { Name = "Atlantic Division" },
                        new Division { Name = "Central Division" },
                        new Division { Name = "Southeast Division" },
                        new Division { Name = "Northwest Division" },
                        new Division { Name = "Pacific Division" },
                        new Division { Name = "Southwest Division" }

                    };
                    _dbContext.Divisions.AddRange(divisionsData);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
