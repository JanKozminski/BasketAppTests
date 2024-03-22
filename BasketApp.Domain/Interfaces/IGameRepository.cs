using BasketApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Domain.Interfaces
{
    public interface IGameRepository
    {
        Task Create(Domain.Entities.Game game);
        Task<IEnumerable<Game>> GetAllGamesAsync();
    }
}
