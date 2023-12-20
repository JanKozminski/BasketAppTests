using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Domain.Entities
{
    public class TeamHistoryLink
    {
      
        public  int HistoricalTeamID { get; set; } = default!;

        [ForeignKey("HistoricalTeamID")]
        public  virtual HistoricalTeam? HistoricalTeam { get; set; }

        public int HistoricalPlayerID { get; set; } = default!;

        [ForeignKey("HistoricalPlayerID")]
        public virtual HistoricalPlayer? HistoricalPlayer { get; set; }

        public DateTime SeasonStartDate { get; set; } = default!;

        public DateTime? SeasonEndDate { get; set; }
    }
}

