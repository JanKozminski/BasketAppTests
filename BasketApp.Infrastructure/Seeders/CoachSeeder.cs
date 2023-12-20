using BasketApp.Domain.Entities;
using BasketApp.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Infrastructure.Seeders
{
    public class CoachSeeder
    {
        private readonly BasketAppDbContext _dbContext;
        public CoachSeeder(BasketAppDbContext dbContext)
        {

            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.Coaches.Any())
                {
                    int losAngelesId = 6;
                    int newYorkId = 7;
                    int bostonId = 8;
                    int philadelphiaId = 9;
                    int torontoId = 10;
                    int chicagoId = 11;
                    int clevelandId = 12;
                    int detroitId = 13;
                    int indianaId = 14;
                    int milwaukeeId = 15;
                    int atlantaId = 16;
                    int charlotteId = 17;
                    int miamiId = 18;
                    int orlandoId = 19;
                    int washingtonId = 20;
                    int denverId = 21;
                    int minnesotaId = 22;
                    int oklahomaCityId = 23;
                    int portlandId = 24;
                    int utahId = 25;
                    int goldenStateId = 26;
                    int phoenixId = 27;
                    int sacramentoId = 28;
                    int dallasId = 29;
                    int memphisId = 30;
                    int houstonId = 31;
                    int newOrleansId = 32;
                    int sanAntonioId = 33;
                    int losAngelesClippersId = 34;
                    int brooklynId = 35;


                    var coachesData = new List<CurrentCoaches>
                    {
                        new CurrentCoaches { Name = "Quin Snyder", TeamID = atlantaId  },
                        new CurrentCoaches { Name = "Joe Mazzulla", TeamID = bostonId },
                        new CurrentCoaches { Name = "Jacque Vaughn", TeamID = brooklynId },
                        new CurrentCoaches { Name = "Steve Clifford", TeamID = charlotteId },
                        new CurrentCoaches { Name = "Billy Donovan", TeamID = chicagoId },
                        new CurrentCoaches { Name = "J. B. Bickerstaff", TeamID = clevelandId },
                        new CurrentCoaches { Name = "Jason Kidd", TeamID = dallasId },
                        new CurrentCoaches { Name = "Michael Malone", TeamID = denverId },
                        new CurrentCoaches { Name = "Monty Williams", TeamID = detroitId },
                        new CurrentCoaches { Name = "Steve Kerr", TeamID = goldenStateId },
                        new CurrentCoaches { Name = "Ime Udoka", TeamID = houstonId },
                        new CurrentCoaches { Name = "Rick Carlisle", TeamID = indianaId },
                        new CurrentCoaches { Name = "Tyronn Lue", TeamID = losAngelesClippersId },
                        new CurrentCoaches { Name = "Darvin Ham", TeamID = losAngelesId },
                        new CurrentCoaches { Name = "Taylor Jenkins", TeamID = memphisId },
                        new CurrentCoaches { Name = "Erik Spoelstra", TeamID = miamiId },
                        new CurrentCoaches { Name = "Adrian Griffin", TeamID = milwaukeeId },
                        new CurrentCoaches { Name = "Chris Finch", TeamID = minnesotaId },
                        new CurrentCoaches { Name = "Willie Green", TeamID = newOrleansId },
                        new CurrentCoaches { Name = "Tom Thibodeau", TeamID = newYorkId },
                        new CurrentCoaches { Name = "Mark Daigneault", TeamID = oklahomaCityId },
                        new CurrentCoaches { Name = "Jamahl Mosley", TeamID = orlandoId },
                        new CurrentCoaches { Name = "Nick Nurse", TeamID = philadelphiaId },
                        new CurrentCoaches { Name = "Frank Vogel", TeamID = phoenixId },
                        new CurrentCoaches { Name = "Chauncey Billups", TeamID = portlandId },
                        new CurrentCoaches { Name = "Mike Brown", TeamID = sacramentoId },
                        new CurrentCoaches { Name = "Gregg Popovich", TeamID = sanAntonioId},
                        new CurrentCoaches { Name = "Darko Rajaković", TeamID = torontoId},
                        new CurrentCoaches { Name = "Will Hardy", TeamID = utahId},
                        new CurrentCoaches { Name = "Wes Unseld Jr.", TeamID = washingtonId}


                    };
                    _dbContext.Coaches.AddRange(coachesData);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
