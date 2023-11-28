using BasketApp.Domain.Entities;
using BasketApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Infrastructure.Seeders
{
    public class TeamSeeder
    {
        private readonly BasketAppDbContext _dbContext;
        public TeamSeeder(BasketAppDbContext dbContext)
        {

            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.Teams.Any())
                {
                    int eastConferenceId = 2; 
                    int westConferenceId = 1; 

                    int losAngelesCityId = 1;
                    int newYorkCityId = 2;
                    int bostonCityId = 3;
                    int philadelphiaCityId = 4;
                    int torontoCityId = 5;
                    int chicagoCityId = 6;
                    int clevelandCityId = 7;
                    int detroitCityId = 8;
                    int indianapolisCityId = 9;
                    int milwaukeeCityId = 10;
                    int atlantaCityId = 11;
                    int charlotteCityId = 12;
                    int miamiCityId = 13;
                    int orlandoCityId = 14;
                    int washingtonDCCityId = 15;
                    int denverCityId = 16;
                    int minneapolisCityId = 17;
                    int oklahomaCityId = 18;
                    int portlandCityId = 19;
                    int saltLakeCityId = 20;
                    int sanFranciscoCityId = 21;
                    int phoenixCityId = 22;
                    int sacramentoCityId = 23;
                    int dallasCityId = 24;
                    int memphisCityId = 25;
                    int houstonCityId = 26;
                    int newOrleansCityId = 27;
                    int sanAntonioCityId = 28;

                    int atlantic = 1;
                    int central = 2;
                    int southeast = 3;
                    int northwest = 4;
                    int pacific = 5;
                    int southwest = 6;

                   
                    var teamsData = new List<Team>
            {
                new Team { TeamName = "Los Angeles Lakers", ConferenceID = westConferenceId, CityID = losAngelesCityId, DivisionID = pacific  },
                new Team { TeamName = "New York Knicks", ConferenceID = eastConferenceId, CityID = newYorkCityId, DivisionID = atlantic  },
                new Team { TeamName = "Boston Celtics", ConferenceID = eastConferenceId, CityID = bostonCityId, DivisionID = atlantic  },
                new Team { TeamName = "Philadelphia 76ers", ConferenceID = eastConferenceId, CityID = philadelphiaCityId, DivisionID = atlantic  },
                new Team { TeamName = "Toronto Raptors", ConferenceID = eastConferenceId, CityID = torontoCityId, DivisionID = atlantic  },
                new Team { TeamName = "Chicago Bulls", ConferenceID = eastConferenceId, CityID = chicagoCityId, DivisionID = central  },
                new Team { TeamName = "Cleveland Cavaliers", ConferenceID = eastConferenceId, CityID = clevelandCityId, DivisionID = central  },
                new Team { TeamName = "Detroit Pistons", ConferenceID = eastConferenceId, CityID = detroitCityId, DivisionID = central  },
                new Team { TeamName = "Indiana Pacers", ConferenceID = eastConferenceId, CityID = indianapolisCityId, DivisionID = central },
                new Team { TeamName = "Milwaukee Bucks", ConferenceID = eastConferenceId, CityID = milwaukeeCityId, DivisionID = central  },
                new Team { TeamName = "Atlanta Hawks", ConferenceID = eastConferenceId, CityID = atlantaCityId, DivisionID = southeast  },
                new Team { TeamName = "Charlotte Hornets", ConferenceID = eastConferenceId, CityID = charlotteCityId, DivisionID = southeast  },
                new Team { TeamName = "Miami Heat", ConferenceID = eastConferenceId, CityID = miamiCityId, DivisionID = southeast  },
                new Team { TeamName = "Orlando Magic", ConferenceID = eastConferenceId, CityID = orlandoCityId, DivisionID = southeast  },
                new Team { TeamName = "Washington Wizards", ConferenceID = eastConferenceId, CityID = washingtonDCCityId, DivisionID = southeast  },
                new Team { TeamName = "Denver Nuggets", ConferenceID = westConferenceId, CityID = denverCityId, DivisionID = northwest  },
                new Team { TeamName = "Minnesota Timberwolves", ConferenceID = westConferenceId, CityID = minneapolisCityId, DivisionID = northwest  },
                new Team { TeamName = "Oklahoma City Thunder", ConferenceID = westConferenceId, CityID = oklahomaCityId, DivisionID = northwest  },
                new Team { TeamName = "Portland Trail Blazers", ConferenceID = westConferenceId, CityID = portlandCityId, DivisionID = northwest  },
                new Team { TeamName = "Utah Jazz", ConferenceID = westConferenceId, CityID = saltLakeCityId, DivisionID = northwest },
                new Team { TeamName = "Golden State Warriors", ConferenceID = westConferenceId, CityID = sanFranciscoCityId, DivisionID = pacific  },
                new Team { TeamName = "Phoenix Suns", ConferenceID = westConferenceId, CityID = phoenixCityId, DivisionID = pacific  },
                new Team { TeamName = "Sacramento Kings", ConferenceID = westConferenceId, CityID = sacramentoCityId, DivisionID = pacific  },
                new Team { TeamName = "Dallas Mavericks", ConferenceID = westConferenceId, CityID = dallasCityId, DivisionID = southwest },
                new Team { TeamName = "Memphis Grizzlies", ConferenceID = westConferenceId, CityID = memphisCityId, DivisionID = southwest },
                new Team { TeamName = "Houston Rockets", ConferenceID = westConferenceId, CityID = houstonCityId, DivisionID = southwest },
                new Team { TeamName = "New Orleans Pelicans", ConferenceID = westConferenceId, CityID = newOrleansCityId, DivisionID = southwest },
                new Team { TeamName = "San Antonio Spurs", ConferenceID = westConferenceId, CityID = sanAntonioCityId, DivisionID = southwest },
                new Team { TeamName = "Los Angeles Clippers", ConferenceID = westConferenceId, CityID = losAngelesCityId, DivisionID = pacific },
                new Team { TeamName = "Brooklyn Nets", ConferenceID = westConferenceId, CityID = newYorkCityId, DivisionID = atlantic  },

            };
                    _dbContext.Teams.AddRange(teamsData);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
        private int GetConferenceId(string conferenceName)
        {
            return _dbContext.Conferences.SingleOrDefault(c => c.Name == conferenceName)?.Id ?? 0;
        }

        private int GetCityId(string cityName)
        {
            return _dbContext.Cities.SingleOrDefault(c => c.Name == cityName)?.Id ?? 0;
        }
        private int GetDivisionId(string divisionName)
        {
            return _dbContext.Cities.SingleOrDefault(c => c.Name == divisionName)?.Id ?? 0;
        }
    }
}
