using BasketApp.Application.DTOs;

namespace BasketApp.MVC.ViewModels
{
    public class GamesListViewModel
    {
        public IEnumerable<GameDto> Games { get; set; }
    }
}
