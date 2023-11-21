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
        [Key, Column(Order = 0)]
        public  int TeamID { get; set; } = default!;

        [ForeignKey("TeamID")]
        public  virtual Team? Team { get; set; }

        [Key, Column(Order = 1)]
        public  int HistoricalTeamID { get; set; } = default!;

        [ForeignKey("HistoricalTeamID")]
        public  virtual HistoricalTeam? HistoricalTeam { get; set; }

        public DateTime LinkStartDate { get; set; } = default!;

        public DateTime? LinkEndDate { get; set; }
    }
}

