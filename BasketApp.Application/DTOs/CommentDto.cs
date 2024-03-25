using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Application.DTOs
{
    public class CommentDto
    {
        public string Text { get; set; } = default!;

        public int GameId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
