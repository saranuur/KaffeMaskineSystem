using KaffeMaskineSystem.Models;
using KaffeMaskineSystem.Repositories;
using KaffeMaskineSystem.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KaffeMaskineSystem.Services
{
    public class RefillService
    {
        private readonly IRefillRepository _refillRepository;

        public RefillService(IRefillRepository refillRepository)
        {
            _refillRepository = refillRepository;
        }

        public Task<List<Refill>> GetAllRefillsAsync()
        {
            return _refillRepository.GetAllRefillsAsync();
        }

        public Task<Refill> GetRefillByIdAsync(int refillId)
        {
            return _refillRepository.GetRefillByIdAsync(refillId);
        }

        public Task<Refill> AddRefillAsync(Refill refill)
        {
            return _refillRepository.AddRefillAsync(refill);
        }

        public Task DeleteRefillAsync(int refillId)
        {
            return _refillRepository.DeleteRefillAsync(refillId);
        }
    }
}

