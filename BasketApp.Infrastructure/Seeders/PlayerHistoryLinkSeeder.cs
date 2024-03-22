//using BasketApp.Domain.Entities;
//using BasketApp.Infrastructure.Persistence;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasketApp.Infrastructure.Seeders
//{
//    public class PlayerHistoryLinkSeeder
//    {
//        private readonly BasketAppDbContext _dbContext;
//        public PlayerHistoryLinkSeeder(BasketAppDbContext dbContext)
//        {

//            _dbContext = dbContext;
//        }

//        public async Task Seed()
//        {
//            if (await _dbContext.Database.CanConnectAsync())
//            {
//                if (!_dbContext.PlayerHistoryLink.Any())
//                {
//                    var playerhistorylinkData = new List<PlayerHistoryLink>
//                    {
//                        new PlayerHistoryLink {
//                            HistoricalPlayerID = 119, 
//                            HistoricalTeamID = 55, 
//                            SeasonStartDate = new DateTime(1995, 10, 3), 
//                            SeasonEndDate = new DateTime(1996, 6, 16), 
//                            Achievements = "MVP Finals, MVP sezonu", 
//                            Role = "Shooting Guard" 
//                        },
    
//                        new PlayerHistoryLink { HistoricalPlayerID = 120,
//                            HistoricalTeamID = 54,
//                            SeasonStartDate = new DateTime(1990, 10, 3),
//                            SeasonEndDate = new DateTime(1991, 6, 12),
//                            Achievements = "Najlepszy obrońca",
//                            Role = "Power Forward" 
//                        },
    
//                        new PlayerHistoryLink { HistoricalPlayerID = 121,
//                            HistoricalTeamID = 55, 
//                            SeasonStartDate = new DateTime(1995, 10, 3), 
//                            SeasonEndDate = new DateTime(1996, 6, 16), 
//                            Achievements = "All-NBA First Team", Role = "Small Forward" 
//                        },

    

//                    };
//                    _dbContext.PlayerHistoryLink.AddRange(playerhistorylinkData);
//                    await _dbContext.SaveChangesAsync();
//                }
//            }
//        }
//    }
//}
