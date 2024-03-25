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
    public class CommentRepository : ICommentRepository
    {
        private readonly BasketAppDbContext _context;

        public CommentRepository(BasketAppDbContext context)
        {
            _context = context;
        }

        public async Task AddCommentAsync(Comment comment)
        {
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Comment>> GetCommentsByGameIdAsync(int gameId)
        {
            return await _context.Comments
                .Where(comment => comment.GameId == gameId)
                .ToListAsync();
        }
    }
}
