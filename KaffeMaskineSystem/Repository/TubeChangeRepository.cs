using KaffeMaskineSystem.Data;
using KaffeMaskineSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace KaffeMaskineSystem.Repository
{
    public class TubeChangeRepository : ITubeChangeRepository
    {
        private readonly AppDbContext _context;

        public TubeChangeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TubeChange>> GetAllChangesAsync()
        {
            return await _context.TubeChanges.ToListAsync();
        }

        public async Task<TubeChange> GetChangeByIdAsync(int id)
        {
            return await _context.TubeChanges.FindAsync(id);
        }

        public async Task AddChangeAsync(TubeChange change)
        {
            await _context.TubeChanges.AddAsync(change);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateChangeAsync(TubeChange change)
        {
            _context.TubeChanges.Update(change);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteChangeAsync(int id)
        {
            var change = await _context.TubeChanges.FindAsync(id);
            if (change != null)
            {
                _context.TubeChanges.Remove(change);
                await _context.SaveChangesAsync();
            }
        }
    }
}