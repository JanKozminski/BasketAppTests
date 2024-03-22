using BasketApp.Domain.Entities;
using BasketApp.Domain.Interfaces;
using BasketApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Infrastructure.Repositories
{
    public class HistoricalTeamRepository : IHistoricalTeamRepository
    {
        private readonly BasketAppDbContext _context;

        public HistoricalTeamRepository(BasketAppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<HistoricalTeam>> GetAllHistoricalTeamsAsync()
        {
            return await _context.HistoricalTeams.ToListAsync();
        }

        public async Task<HistoricalTeam> GetHistoricalTeamByIdAsync(int id)
        {
            return await _context.HistoricalTeams.FindAsync(id);
        }
    }
}
