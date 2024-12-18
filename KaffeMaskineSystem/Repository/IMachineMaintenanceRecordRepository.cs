using KaffeMaskineSystem.Models;

namespace KaffeMaskineSystem.Repository
{
    public interface IMachineMaintenanceRecordRepository
    {
        Task<IEnumerable<MachineMaintenanceRecord>> GetAllRecordsAsync();
        Task<MachineMaintenanceRecord> GetRecordByIdAsync(int id);
        Task AddRecordAsync(MachineMaintenanceRecord record);
        Task UpdateRecordAsync(MachineMaintenanceRecord record);
        Task DeleteRecordAsync(int id);
    }
}
