using KaffeMaskineSystem.Data;
using KaffeMaskineSystem.Models;
using Microsoft.EntityFrameworkCore;


namespace KaffeMaskineSystem.Repository
{
    public class MachineMaintenanceRecordRepository : IMachineMaintenanceRecordRepository
    {
        private readonly AppDbContext _context;

        public MachineMaintenanceRecordRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MachineMaintenanceRecord>> GetAllRecordsAsync()
        {
            return await _context.MachineMaintenanceRecords.ToListAsync();
        }

        public async Task<MachineMaintenanceRecord> GetRecordByIdAsync(int id)
        {
            return await _context.MachineMaintenanceRecords.FindAsync(id);
        }

        public async Task AddRecordAsync(MachineMaintenanceRecord record)
        {
            await _context.MachineMaintenanceRecords.AddAsync(record);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRecordAsync(MachineMaintenanceRecord record)
        {
            _context.MachineMaintenanceRecords.Update(record);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRecordAsync(int id)
        {
            var record = await _context.MachineMaintenanceRecords.FindAsync(id);
            if (record != null)
            {
                _context.MachineMaintenanceRecords.Remove(record);
                await _context.SaveChangesAsync();
            }
        }
    }
}
