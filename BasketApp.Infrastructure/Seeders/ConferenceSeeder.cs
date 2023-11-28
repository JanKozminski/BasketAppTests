using BasketApp.Domain.Entities;
using BasketApp.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Infrastructure.Seeders
{
    public class ConferenceSeeder
    {
        private readonly BasketAppDbContext _dbContext;
        public ConferenceSeeder(BasketAppDbContext dbContext)
        {

            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.Conferences.Any())
                {
                    var conferencesData = new List<Conference>
                    {
                        new Conference { Name = "West Conference" },
                        new Conference { Name = "East Conference" }
                        
                    };
                    _dbContext.Conferences.AddRange(conferencesData);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}

