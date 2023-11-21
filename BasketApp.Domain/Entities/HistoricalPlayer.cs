using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Domain.Entities
{
    public class HistoricalPlayer
    {
        [Key]
        public int Id { get; set; }
        public int PlayerID { get; set; } = default!;

        [ForeignKey("PlayerID")]
        public  virtual Player? Player { get; set; }

        public  int TeamID { get; set; } = default!;

        [ForeignKey("TeamID")]
        public  virtual HistoricalTeam? HistoricalTeam { get; set; }
        public  DateTime SeasonStartDate { get; set; } = default!;
        public DateTime? SeasonEndDate { get; set; }
        public  string? Description { get; set; }
    }
}
