using BasketApp.Domain.Entities;
using BasketApp.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using BasketApp.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Infrastructure.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly BasketAppDbContext _context;

        public PlayerRepository(BasketAppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Player>> GetAllPlayersAsync()
        {
            return await _context.Players.ToListAsync();
        }

        public async Task<Player> GetPlayerByIdAsync(int id)
        {
            return await _context.Players.FindAsync(id);
        }

        public async Task<IEnumerable<Player>> GetPlayersByTeamIdAsync(int teamId)
        {
            return await _context.Players.Where(p => p.TeamID == teamId).ToListAsync();
        }
    }
}
