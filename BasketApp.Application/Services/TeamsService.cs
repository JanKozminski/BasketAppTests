using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasketApp.Domain.Entities;
using BasketApp.Domain.Interfaces;
using BasketApp.Application.DTOs;

namespace BasketApp.Application.Services
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IHistoricalTeamRepository _historicalTeamRepository;
        private readonly IPlayerRepository _playerRepository;

        public TeamService(ITeamRepository teamRepository, IHistoricalTeamRepository historicalTeamRepository, IPlayerRepository playerRepository)
        {
            _teamRepository = teamRepository;
            _historicalTeamRepository = historicalTeamRepository;
            _playerRepository = playerRepository;
        }

        public async Task<IEnumerable<Team>> GetCurrentTeamsAsync()
        {
            return await _teamRepository.GetAllTeamsWithDetailsAsync();
        }

        public async Task<IEnumerable<Team>> GetAllTeamsAsync()
        {
            return await _teamRepository.GetAllTeamsAsync();
        }

        public async Task<IEnumerable<HistoricalTeam>> GetHistoricalTeamsAsync()
        {
            return await _historicalTeamRepository.GetAllHistoricalTeamsAsync();
        }

        public async Task<HistoricalTeam> GetHistoricalTeamByIdAsync(int id)
        {
            return await _historicalTeamRepository.GetHistoricalTeamByIdAsync(id);
        }

        public async Task<TeamRosterDto> GetTeamRosterAsync(int teamId)
        {
            var team = await _teamRepository.GetTeamByIdAsync(teamId);
            var players = await _playerRepository.GetPlayersByTeamIdAsync(teamId);

            return new TeamRosterDto
            {
                Team = team,
                Players = players
            };
        }
    }
}
