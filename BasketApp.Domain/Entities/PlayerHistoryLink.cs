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
        public  int PlayerID { get; set; } = default!;

        [ForeignKey("PlayerID")]
        public  virtual Player? Player { get; set; }

        public  int HistoricalPlayerID { get; set; } = default!;

        [ForeignKey("HistoricalPlayerID")]
        public  virtual HistoricalPlayer? HistoricalPlayer { get; set; }

        public DateTime LinkStartDate { get; set; } = default!;

        public DateTime? LinkEndDate { get; set; } = default!;
    }
}
