using BasketApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Application.DTOs
{
    public class TeamRosterDto
    {
        public Team Team { get; set; }
        public IEnumerable<Player> Players { get; set; }
    }
}
