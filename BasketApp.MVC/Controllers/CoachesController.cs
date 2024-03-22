using BasketApp.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BasketApp.MVC.Controllers
{
    public class CoachesController : Controller
    {
        private readonly ICoachService _coachService;

        public CoachesController(ICoachService coachService)
        {
            _coachService = coachService;
        }

        public async Task<IActionResult> Coaches()
        {
            var coaches = await _coachService.GetAllCoachesAsync();
            return View(coaches);
        }
    }
}
