using BasketApp.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;


namespace BasketApp.Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; } = default!;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int GameId { get; set; }

        public virtual Game Game { get; set; } = default!;

        
        public string? CreatedById { get; set; }

        public IdentityUser? CreatedBy { get; set; }
    }
}
