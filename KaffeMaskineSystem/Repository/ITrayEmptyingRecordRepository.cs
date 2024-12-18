using KaffeMaskineSystem.Models;

namespace KaffeMaskineSystem.Repository
{
    public interface ITrayEmptyingRecordRepository
    {
        Task<IEnumerable<TrayEmptyingRecord>> GetAllRecordsAsync();
        Task<TrayEmptyingRecord> GetRecordByIdAsync(int id);
        Task AddRecordAsync(TrayEmptyingRecord record);
        Task UpdateRecordAsync(TrayEmptyingRecord record);
        Task DeleteRecordAsync(int id);
    }
}
