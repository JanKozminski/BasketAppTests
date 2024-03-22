using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasketApp.Domain.Interfaces;
using BasketApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using BasketApp.Infrastructure.Persistence;

namespace BasketApp.Infrastructure.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly BasketAppDbContext _context;

        public TeamRepository(BasketAppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Team>> GetAllTeamsAsync()
        {
            return await _context.Teams.ToListAsync();
        }

        public async Task<Team> GetTeamByIdAsync(int teamId)
        {
            return await _context.Teams.FindAsync(teamId);
        }


        public async Task<IEnumerable<Team>> GetAllTeamsWithDetailsAsync()
        {
            return await _context.Teams
                .Include(t => t.City)
                .Include(t => t.Conference)
                .Include(t => t.State)
                .Include(t => t.Division)
                .ToListAsync();
        }
    }
}
