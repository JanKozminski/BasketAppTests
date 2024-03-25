using BasketApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Application.GameExtensions.Queries.GetAllGames
{
    public class GetAllGamesQuery : IRequest<IEnumerable<Game>>
    {

    }
}
