using KaffeMaskineSystem.Models;
using KaffeMaskineSystem.Repository;

namespace KaffeMaskineSystem.Services
{
    public class MachineMaintenanceRecordService
    {
        private readonly IMachineMaintenanceRecordRepository _repository;

        public MachineMaintenanceRecordService(IMachineMaintenanceRecordRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<MachineMaintenanceRecord>> GetAllRecordsAsync()
        {
            return await _repository.GetAllRecordsAsync();
        }

        public async Task<MachineMaintenanceRecord> GetRecordByIdAsync(int id)
        {
            return await _repository.GetRecordByIdAsync(id);
        }

        public async Task AddRecordAsync(MachineMaintenanceRecord record)
        {
            await _repository.AddRecordAsync(record);
        }

        public async Task UpdateRecordAsync(MachineMaintenanceRecord record)
        {
            await _repository.UpdateRecordAsync(record);
        }

        public async Task DeleteRecordAsync(int id)
        {
            await _repository.DeleteRecordAsync(id);
        }
    }
}
