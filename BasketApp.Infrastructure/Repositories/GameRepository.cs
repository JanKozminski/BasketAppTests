using BasketApp.Domain.Interfaces;
using BasketApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using BasketApp.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Infrastructure.Repositories
{
    public class GameRepository : IGameRepository
    {

        private readonly BasketAppDbContext _context;

        public GameRepository(BasketAppDbContext context)
        {
            _context = context;
        }

        public async Task Create(Domain.Entities.Game game)
        {
            _context.Add(game);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Game>> GetAllGamesAsync()
        {
            return await _context.Games
                .Include(g => g.Team1)
                .Include(g => g.Team2)
                .ToListAsync();
        }


    }
}
