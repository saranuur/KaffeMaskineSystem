using KaffeMaskineSystem.Models;
using KaffeMaskineSystem.Repository;

namespace KaffeMaskineSystem.Services
{
    public class HistoryService
    {
        private readonly IHistoryRepository _historyRepository;

        public HistoryService(IHistoryRepository historyRepository)
        {
            _historyRepository = historyRepository;
        }

        public async Task<IEnumerable<History>> GetAllHistoriesAsync()
        {
            return await _historyRepository.GetAllHistoriesAsync();
        }

        public async Task<History> GetHistoryByIdAsync(int id)
        {
            return await _historyRepository.GetHistoryByIdAsync(id);
        }

        public async Task AddHistoryAsync(History history)
        {
            await _historyRepository.AddHistoryAsync(history);
        }

        public async Task UpdateHistoryAsync(History history)
        {
            await _historyRepository.UpdateHistoryAsync(history);
        }

        public async Task DeleteHistoryAsync(int id)
        {
            await _historyRepository.DeleteHistoryAsync(id);
        }
    }
}