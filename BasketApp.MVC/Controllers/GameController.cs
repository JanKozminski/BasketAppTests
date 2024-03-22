using BasketApp.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BasketApp.MVC.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameService _gameService;
        private readonly ITeamService _teamService;

        public GameController(IGameService gameService, ITeamService teamService) {
        
            _gameService = gameService;
            _teamService = teamService;
        }

        public async Task<IActionResult> LatestGames()
        {
            var games = await _gameService.GetAllGamesAsync();
            return View(games); 
        }

        public async Task<IActionResult> Create()
        {

            var teams = await _teamService.GetAllTeamsAsync();
            ViewBag.Team1ID = new SelectList(teams, "Id", "TeamName");
            ViewBag.Team2ID = new SelectList(teams, "Id", "TeamName");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Domain.Entities.Game game)
        {

            await _gameService.Create(game);
            return RedirectToAction("Create");
        }
    }
}
