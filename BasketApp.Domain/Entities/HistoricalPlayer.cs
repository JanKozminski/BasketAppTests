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

        public  DateTime DraftDate { get; set; } = default!;
        public DateTime? EndOfCareerDate { get; set; }
        public  string? Description { get; set; }
    }
}
