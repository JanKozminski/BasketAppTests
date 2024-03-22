using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Domain.Entities
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public  DateTime GameDate { get; set; } = default!;
        public  int Team1ID { get; set; } = default!;

        [ForeignKey("Team1ID")]

        public  virtual Team? Team1 { get; set; }

        public  int Team2ID { get; set; } = default!;

        [ForeignKey("Team2ID")]
        public  virtual Team? Team2 { get; set; }
        public  string FinalScore { get; set; } = default!;
        public string? Description { get; set; }
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    }
}
