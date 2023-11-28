using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Domain.Entities
{
    public class CurrentCoaches
    {
        [Key]
        public  int Id { get; set; }
        public  string Name { get; set; } = default!;
        public string? CoachPhotoPath { get; set; }
        public int TeamID { get; set; } = default!;

        [ForeignKey("TeamID")]
        public virtual Team? Team { get; set; }
    }
}
