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
    public class CoachRepository : ICoachRepository
    {
        private readonly BasketAppDbContext _context;

        public CoachRepository(BasketAppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CurrentCoaches>> GetAllCoachesAsync()
        {
            return await _context.Coaches
                .Include(t => t.Team)
                .ToListAsync();
        }
    }
}
