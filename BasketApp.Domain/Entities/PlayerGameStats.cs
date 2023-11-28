using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Domain.Entities
{
    public class PlayerGameStats
    {
        [Key]
        public int Id { get; set; }

        public  int GameID { get; set; } = default!;

        [ForeignKey("GameID")]
        public  virtual Game? Game { get; set; }
        public  int PlayerID { get; set; } = default!;

        [ForeignKey("PlayerID")]
        public  virtual Player? Player { get; set; }

        public  int Points { get; set; } = default!;
        public  int Assists { get; set; } = default!;
        public  int Rebounds { get; set; } = default!;
    }
}
