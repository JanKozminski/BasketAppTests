using BasketApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Application.DTOs
{
	public class GameDto
	{
		[Required]
		public DateTime GameDate { get; set; } = default!;
		public int Team1ID { get; set; } = default!;
		public int Team2ID { get; set; } = default!;
		[Required]
		public string FinalScore { get; set; } = default!;
		public string? Description { get; set; }

        public List<CommentDto> Comments { get; set; } = new List<CommentDto>();

    }
}
