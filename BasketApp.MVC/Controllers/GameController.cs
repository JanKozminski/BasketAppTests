using BasketApp.Application.CommentExtensions.Command;
using BasketApp.Application.CommentExtensions.Query;
using BasketApp.Application.DTOs;
using BasketApp.Application.GameExtensions.Commands.CreateGame;
using BasketApp.Application.GameExtensions.Queries.GetAllGames;
using BasketApp.Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BasketApp.MVC.Controllers
{
    public class GameController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ITeamService _teamService;

        public GameController(IMediator mediator, ITeamService teamService) {

            _mediator = mediator;
            _teamService = teamService;
        }

        public async Task<IActionResult> LatestGames()
        {
            var games = await _mediator.Send(new GetAllGamesQuery());
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
        public async Task<IActionResult> Create(CreateGameCommand game)
        {

			if (game.Team1ID == game.Team2ID)
			{
				ModelState.AddModelError("", "Drużyna 1 i Drużyna 2 nie mogą być takie same.");

				
				var teams = await _teamService.GetAllTeamsAsync();
				ViewBag.Team1ID = new SelectList(teams, "Id", "TeamName", game.Team1ID);
				ViewBag.Team2ID = new SelectList(teams, "Id", "TeamName", game.Team2ID);

				return View(game);
			}



            await _mediator.Send(game);
            return RedirectToAction("LatestGames");
        }

        [HttpGet]
        public async Task<IActionResult> ViewComments(int gameId)
        {
            var query = new GetCommentsByGameQuery(gameId);
            var comments = await _mediator.Send(query);


            return PartialView("_CommentsPartial", comments);
        }
        [HttpPost]
        public async Task<IActionResult> AddCommentAsync(CreateCommentCommand comment)
        {
            if (User.Identity == null || !User.Identity.IsAuthenticated)
            {
                TempData["AlertMessage"] = "Musisz być zalogowany, aby dodać komentarz. Proszę ";
                return RedirectToAction("LatestGames");
            }

            await _mediator.Send(comment);
            return RedirectToAction("LatestGames");
        }

    }
}
