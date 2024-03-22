using BasketApp.Application.Services;
using BasketApp.Domain.Interfaces;
using BasketApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BasketApp.MVC.Controllers
{
    public class TeamsController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamsController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IActionResult ChooseTeamType()
        {
            return View();
        }

        public async Task<IActionResult> CurrentTeams()
        {
            var teams = await _teamService.GetCurrentTeamsAsync();
            return View(teams);
        }

        public async Task<IActionResult> HistoricalTeams()
        {
            var historicalTeams = await _teamService.GetHistoricalTeamsAsync();
            return View(historicalTeams);
        }

        public async Task<IActionResult> Details(int id)
        {
            var team = await _teamService.GetHistoricalTeamByIdAsync(id);
            if (team == null)
            {
                return NotFound();
            }
            return View(team);
        }

        public async Task<IActionResult> Roster(int id)
        {
            var rosterDto = await _teamService.GetTeamRosterAsync(id);
            var viewModel = new TeamRosterViewModel
            {
                Team = rosterDto.Team,
                Players = rosterDto.Players
            };

            return View(viewModel);
        }
    }


}
