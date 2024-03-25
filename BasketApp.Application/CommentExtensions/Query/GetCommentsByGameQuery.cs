using BasketApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Application.CommentExtensions.Query
{
    public class GetCommentsByGameQuery : IRequest<IEnumerable<Comment>>
    {
        public int GameId { get; }

        public GetCommentsByGameQuery(int gameId)
        {
            GameId = gameId;
        }
    }
}
