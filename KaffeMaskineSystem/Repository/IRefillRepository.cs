using KaffeMaskineSystem.Models;

namespace KaffeMaskineSystem.Repository
{
    public interface IRefillRepository
    {
        Task<List<Refill>> GetAllRefillsAsync();
        Task<Refill> GetRefillByIdAsync(int refillId);
        Task<Refill> AddRefillAsync(Refill refill);
        Task DeleteRefillAsync(int refillId);
    }
}
