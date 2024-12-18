using KaffeMaskineSystem.Models;
using KaffeMaskineSystem.Repository;

namespace KaffeMaskineSystem.Services
{
    public class TrayEmptyingRecordService
    {
        private readonly ITrayEmptyingRecordRepository _repository;

        public TrayEmptyingRecordService(ITrayEmptyingRecordRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<TrayEmptyingRecord>> GetAllRecordsAsync()
        {
            return await _repository.GetAllRecordsAsync();
        }

        public async Task<TrayEmptyingRecord> GetRecordByIdAsync(int id)
        {
            return await _repository.GetRecordByIdAsync(id);
        }

        public async Task AddRecordAsync(TrayEmptyingRecord record)
        {
            await _repository.AddRecordAsync(record);
        }

        public async Task UpdateRecordAsync(TrayEmptyingRecord record)
        {
            await _repository.UpdateRecordAsync(record);
        }

        public async Task DeleteRecordAsync(int id)
        {
            await _repository.DeleteRecordAsync(id);
        }
    }
}
