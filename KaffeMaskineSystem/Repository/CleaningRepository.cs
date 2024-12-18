using KaffeMaskineSystem.Data;
using KaffeMaskineSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaffeMaskineSystem.Repositories
{
    public class CleaningRepository : ICleaningRepository
    {
        private readonly AppDbContext _context;

        public CleaningRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Cleaning>> GetAllCleaningsAsync()
        {
            return await _context.Cleanings.Include(c => c.CoffeeMachine).ToListAsync();
        }

        public async Task<Cleaning> GetCleaningByIdAsync(int cleaningId)
        {
            return await _context.Cleanings.Include(c => c.CoffeeMachine)
                                           .FirstOrDefaultAsync(c => c.CleaningID == cleaningId);
        }

        public async Task<Cleaning> AddCleaningAsync(Cleaning cleaning)
        {
            _context.Cleanings.Add(cleaning);
            await _context.SaveChangesAsync();
            return cleaning;
        }

        public async Task<Cleaning> UpdateCleaningAsync(Cleaning cleaning)
        {
            _context.Cleanings.Update(cleaning);
            await _context.SaveChangesAsync();
            return cleaning;
        }

        public async Task DeleteCleaningAsync(int cleaningId)
        {
            var cleaning = await _context.Cleanings.FindAsync(cleaningId);
            if (cleaning != null)
            {
                _context.Cleanings.Remove(cleaning);
                await _context.SaveChangesAsync();
            }
        }
    }
}
