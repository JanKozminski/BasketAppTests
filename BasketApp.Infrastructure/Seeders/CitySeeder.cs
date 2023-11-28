using BasketApp.Domain.Entities;
using BasketApp.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Infrastructure.Seeders
{
    public class CitySeeder
    {
        private readonly BasketAppDbContext _dbContext;
        public CitySeeder(BasketAppDbContext dbContext)
        {

            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.Cities.Any())
                {
                    var citiesData = new List<City>
                    {
                        new City { Name = "Los Angeles" },
                        new City { Name = "New York" },
                        new City { Name = "Boston" },
                        new City { Name = "Philadelphia" },
                        new City { Name = "Toronto" },
                        new City { Name = "Chicago" },
                        new City { Name = "Cleveland" },
                        new City { Name = "Detroit" },
                        new City { Name = "Indianapolis" },
                        new City { Name = "Milwaukee" },
                        new City { Name = "Atlanta" },
                        new City { Name = "Charlotte" },
                        new City { Name = "Miami" },
                        new City { Name = "Orlando" },
                        new City { Name = "Washington D.C." },
                        new City { Name = "Denver" },
                        new City { Name = "Minneapolis" },
                        new City { Name = "Oklahoma City" },
                        new City { Name = "Portland" },
                        new City { Name = "Salt Lake City" },
                        new City { Name = "San Francisco" },
                        new City { Name = "Phoenix" },
                        new City { Name = "Sacramento" },
                        new City { Name = "Dallas" },
                        new City { Name = "Memphis" },
                        new City { Name = "Houston" },
                        new City { Name = "New Orleans" },
                        new City { Name = "San Antonio" }

                    };
                    _dbContext.Cities.AddRange(citiesData);
                    await _dbContext.SaveChangesAsync();

                }
            }
        }
    }
}
