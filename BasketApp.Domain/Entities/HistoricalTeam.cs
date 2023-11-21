using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Domain.Entities
{
    public class HistoricalTeam
    {
        [Key]
        public required int Id { get; set; }
        public  int TeamID { get; set; } = default!;

        [ForeignKey("TeamID")]
        public  virtual Team? Team { get; set; }
        public  DateTime SeasonStartDate { get; set; } = default!;
        public DateTime? SeasonEndDate { get; set; }
        public string? SuperStarPlayer { get; set; }
        public string Description { get; set; } = default!;

    }
}
