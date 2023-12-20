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

                    int arizonaStateId = 3;
                    int californiaStateId = 5;
                    int coloradoStateId = 6;
                    int floridaStateId = 9;
                    int georgiaStateId = 10;
                    int illinoisStateId = 13;
                    int indianaStateId = 14;
                    int louisianaStateId = 18;
                    int massachusettsStateId = 21;
                    int michiganStateId = 22;
                    int minnesotaStateId = 23;
                    int newYorkStateId = 32;
                    int northCarolinaStateId = 33;
                    int ohioStateId = 35;
                    int oklahomaStateId = 36;
                    int oregonStateId = 37;
                    int pennsylvaniaStateId = 38;
                    int tennesseeStateId = 42;
                    int texasStateId = 43;
                    int utahStateId = 44;
                    int washingtonStateId = 47;
                    int wisconsinStateId = 49;


                    var teamsData = new List<Team>
            {
                new Team { TeamName = "Los Angeles Lakers", ConferenceID = westConferenceId, CityID = losAngelesCityId, DivisionID = pacific, StateID = californiaStateId  },
                new Team { TeamName = "New York Knicks", ConferenceID = eastConferenceId, CityID = newYorkCityId, DivisionID = atlantic, StateID = newYorkStateId  },
                new Team { TeamName = "Boston Celtics", ConferenceID = eastConferenceId, CityID = bostonCityId, DivisionID = atlantic, StateID = massachusettsStateId  },
                new Team { TeamName = "Philadelphia 76ers", ConferenceID = eastConferenceId, CityID = philadelphiaCityId, DivisionID = atlantic, StateID = pennsylvaniaStateId  },
                new Team { TeamName = "Toronto Raptors", ConferenceID = eastConferenceId, CityID = torontoCityId, DivisionID = atlantic, StateID = pennsylvaniaStateId  },
                new Team { TeamName = "Chicago Bulls", ConferenceID = eastConferenceId, CityID = chicagoCityId, DivisionID = central, StateID = illinoisStateId  },
                new Team { TeamName = "Cleveland Cavaliers", ConferenceID = eastConferenceId, CityID = clevelandCityId, DivisionID = central, StateID = ohioStateId  },
                new Team { TeamName = "Detroit Pistons", ConferenceID = eastConferenceId, CityID = detroitCityId, DivisionID = central, StateID = michiganStateId  },
                new Team { TeamName = "Indiana Pacers", ConferenceID = eastConferenceId, CityID = indianapolisCityId, DivisionID = central, StateID = indianaStateId },
                new Team { TeamName = "Milwaukee Bucks", ConferenceID = eastConferenceId, CityID = milwaukeeCityId, DivisionID = central, StateID = wisconsinStateId  },
                new Team { TeamName = "Atlanta Hawks", ConferenceID = eastConferenceId, CityID = atlantaCityId, DivisionID = southeast, StateID = georgiaStateId  },
                new Team { TeamName = "Charlotte Hornets", ConferenceID = eastConferenceId, CityID = charlotteCityId, DivisionID = southeast, StateID = northCarolinaStateId  },
                new Team { TeamName = "Miami Heat", ConferenceID = eastConferenceId, CityID = miamiCityId, DivisionID = southeast, StateID = floridaStateId  },
                new Team { TeamName = "Orlando Magic", ConferenceID = eastConferenceId, CityID = orlandoCityId, DivisionID = southeast, StateID = floridaStateId },
                new Team { TeamName = "Washington Wizards", ConferenceID = eastConferenceId, CityID = washingtonDCCityId, DivisionID = southeast, StateID = washingtonStateId  },
                new Team { TeamName = "Denver Nuggets", ConferenceID = westConferenceId, CityID = denverCityId, DivisionID = northwest, StateID = coloradoStateId  },
                new Team { TeamName = "Minnesota Timberwolves", ConferenceID = westConferenceId, CityID = minneapolisCityId, DivisionID = northwest, StateID = minnesotaStateId  },
                new Team { TeamName = "Oklahoma City Thunder", ConferenceID = westConferenceId, CityID = oklahomaCityId, DivisionID = northwest, StateID = oklahomaStateId  },
                new Team { TeamName = "Portland Trail Blazers", ConferenceID = westConferenceId, CityID = portlandCityId, DivisionID = northwest, StateID = oregonStateId  },
                new Team { TeamName = "Utah Jazz", ConferenceID = westConferenceId, CityID = saltLakeCityId, DivisionID = northwest, StateID = utahStateId },
                new Team { TeamName = "Golden State Warriors", ConferenceID = westConferenceId, CityID = sanFranciscoCityId, DivisionID = pacific, StateID = californiaStateId  },
                new Team { TeamName = "Phoenix Suns", ConferenceID = westConferenceId, CityID = phoenixCityId, DivisionID = pacific, StateID = arizonaStateId  },
                new Team { TeamName = "Sacramento Kings", ConferenceID = westConferenceId, CityID = sacramentoCityId, DivisionID = pacific, StateID = californiaStateId  },
                new Team { TeamName = "Dallas Mavericks", ConferenceID = westConferenceId, CityID = dallasCityId, DivisionID = southwest, StateID = texasStateId },
                new Team { TeamName = "Memphis Grizzlies", ConferenceID = westConferenceId, CityID = memphisCityId, DivisionID = southwest, StateID = tennesseeStateId },
                new Team { TeamName = "Houston Rockets", ConferenceID = westConferenceId, CityID = houstonCityId, DivisionID = southwest, StateID = texasStateId },
                new Team { TeamName = "New Orleans Pelicans", ConferenceID = westConferenceId, CityID = newOrleansCityId, DivisionID = southwest, StateID = louisianaStateId },
                new Team { TeamName = "San Antonio Spurs", ConferenceID = westConferenceId, CityID = sanAntonioCityId, DivisionID = southwest, StateID = texasStateId },
                new Team { TeamName = "Los Angeles Clippers", ConferenceID = westConferenceId, CityID = losAngelesCityId, DivisionID = pacific, StateID = californiaStateId },
                new Team { TeamName = "Brooklyn Nets", ConferenceID = westConferenceId, CityID = newYorkCityId, DivisionID = atlantic, StateID = newYorkStateId  },

            };
                    _dbContext.Teams.AddRange(teamsData);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
        
    }
}
