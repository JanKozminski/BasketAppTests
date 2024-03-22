using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Domain.Entities
{
    public class PlayerHistoryLink
    {
       
        public  int HistoricalPlayerID { get; set; } = default!;

        [ForeignKey("HistoricalPlayerID")]
        public  virtual HistoricalPlayer? HistoricalPlayer { get; set; }

        public int HistoricalTeamID { get; set; } = default!;

        [ForeignKey("HistoricalTeamID")]
        public virtual HistoricalTeam? HistoricalTeam { get; set; }

        public DateTime SeasonStartDate { get; set; } = default!;

        public DateTime? SeasonEndDate { get; set; } = default!;

        public string Achievements { get; set; } = default!;
        public string Role { get; set; } = default!;
    }
}
