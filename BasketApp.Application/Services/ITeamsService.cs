using BasketApp.Domain.Entities;
using BasketApp.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Domain.Interfaces
{
    public interface ITeamService
    {
      Task<IEnumerable<Team>> GetCurrentTeamsAsync();
      Task<IEnumerable<HistoricalTeam>> GetHistoricalTeamsAsync();
      Task<IEnumerable<Team>> GetAllTeamsAsync();
      Task<HistoricalTeam> GetHistoricalTeamByIdAsync(int id);

      Task<TeamRosterDto> GetTeamRosterAsync(int teamId);
    }
}
