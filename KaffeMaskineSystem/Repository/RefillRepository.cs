using KaffeMaskineSystem.Data;
using KaffeMaskineSystem.Models;
using KaffeMaskineSystem.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KaffeMaskineSystem.Repositories
{
    public class RefillRepository : IRefillRepository
    {
        private readonly AppDbContext _context;

        public RefillRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Refill>> GetAllRefillsAsync()
        {
            return await _context.Refills
                .Include(r => r.User)
                .Include(r => r.CoffeeMachine)
                .ToListAsync();
        }

        public async Task<Refill> GetRefillByIdAsync(int refillId)
        {
            return await _context.Refills
                .Include(r => r.User)
                .Include(r => r.CoffeeMachine)
                .FirstOrDefaultAsync(r => r.RefillID == refillId);
        }

        public async Task<Refill> AddRefillAsync(Refill refill)
        {
            _context.Refills.Add(refill);
            await _context.SaveChangesAsync();
            return refill;
        }

        public async Task DeleteRefillAsync(int refillId)
        {
            var refill = await _context.Refills.FindAsync(refillId);
            if (refill != null)
            {
                _context.Refills.Remove(refill);
                await _context.SaveChangesAsync();
            }
        }
    }
}
