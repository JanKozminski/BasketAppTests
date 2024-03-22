using BasketApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Domain.Interfaces
{
    public interface IHistoricalTeamRepository
    {
        Task<IEnumerable<HistoricalTeam>> GetAllHistoricalTeamsAsync();
        Task<HistoricalTeam> GetHistoricalTeamByIdAsync(int id);
    }
}
