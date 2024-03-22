using BasketApp.Domain.Entities;

namespace BasketApp.MVC.Models
{
    public class TeamRosterViewModel
    {
        public Team Team { get; set; }
        public IEnumerable<Player>? Players { get; set; }
    }
}
