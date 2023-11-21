using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Domain.Entities
{
    public class Player
    {
        [Key]
        public required int Id { get; set; }
        public string Name { get; set; } = default!;
        public int? TeamID { get; set; }

        [ForeignKey("TeamID")]
        public virtual Team? Team { get; set; }
        public string? PlayerPhotoPath { get; set; }

    }
}
