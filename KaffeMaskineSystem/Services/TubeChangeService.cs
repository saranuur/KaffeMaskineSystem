using KaffeMaskineSystem.Models;
using KaffeMaskineSystem.Repository;

namespace KaffeMaskineSystem.Services
{
    public class TubeChangeService
    {
        private readonly ITubeChangeRepository _repository;

        public TubeChangeService(ITubeChangeRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<TubeChange>> GetAllChangesAsync()
        {
            return await _repository.GetAllChangesAsync();
        }

        public async Task<TubeChange> GetChangeByIdAsync(int id)
        {
            return await _repository.GetChangeByIdAsync(id);
        }

        public async Task AddChangeAsync(TubeChange change)
        {
            await _repository.AddChangeAsync(change);
        }

        public async Task UpdateChangeAsync(TubeChange change)
        {
            await _repository.UpdateChangeAsync(change);
        }

        public async Task DeleteChangeAsync(int id)
        {
            await _repository.DeleteChangeAsync(id);
        }
    }
}
