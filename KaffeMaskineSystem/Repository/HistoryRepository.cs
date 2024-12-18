using KaffeMaskineSystem.Data;
using KaffeMaskineSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace KaffeMaskineSystem.Repository
{
    public class HistoryRepository : IHistoryRepository
    {
        private readonly AppDbContext _context;

        public HistoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<History>> GetAllHistoriesAsync()
        {
            return await _context.Histories.ToListAsync();
        }

        public async Task<History> GetHistoryByIdAsync(int id)
        {
            return await _context.Histories.FindAsync(id);
        }

        public async Task AddHistoryAsync(History history)
        {
            await _context.Histories.AddAsync(history);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateHistoryAsync(History history)
        {
            _context.Histories.Update(history);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteHistoryAsync(int id)
        {
            var history = await _context.Histories.FindAsync(id);
            if (history != null)
            {
                _context.Histories.Remove(history);
                await _context.SaveChangesAsync();
            }
        }
    }
}
