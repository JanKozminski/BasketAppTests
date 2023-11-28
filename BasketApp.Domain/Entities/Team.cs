using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Domain.Entities
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TeamName { get; set; } = default!;
        public string? TeamPhotoPath { get; set; }
        public int CityID { get; set; } = default!;

        [ForeignKey("CityID")]
        public virtual City? City { get; set; }
        public int ConferenceID { get; set; } = default!;

        [ForeignKey("ConferenceID")]
        public virtual Conference? Conference { get; set; }
        public int StateID { get; set; } = default!;

        [ForeignKey("StateID")]
        public virtual State? State { get; set; }
        public int DivisionID { get; set; } = default!;

        [ForeignKey("DivisionID")]
        public virtual Division? Division { get; set; }



    }
}
