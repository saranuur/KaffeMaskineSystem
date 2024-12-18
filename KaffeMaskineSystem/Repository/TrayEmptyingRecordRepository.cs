using KaffeMaskineSystem.Data;
using KaffeMaskineSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace KaffeMaskineSystem.Repository
{
    public class TrayEmptyingRecordRepository : ITrayEmptyingRecordRepository
    {
        private readonly AppDbContext _context;

        public TrayEmptyingRecordRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TrayEmptyingRecord>> GetAllRecordsAsync()
        {
            return await _context.TrayEmptyingRecords.ToListAsync();
        }

        public async Task<TrayEmptyingRecord> GetRecordByIdAsync(int id)
        {
            return await _context.TrayEmptyingRecords.FindAsync(id);
        }

        public async Task AddRecordAsync(TrayEmptyingRecord record)
        {
            await _context.TrayEmptyingRecords.AddAsync(record);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRecordAsync(TrayEmptyingRecord record)
        {
            _context.TrayEmptyingRecords.Update(record);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRecordAsync(int id)
        {
            var record = await _context.TrayEmptyingRecords.FindAsync(id);
            if (record != null)
            {
                _context.TrayEmptyingRecords.Remove(record);
                await _context.SaveChangesAsync();
            }
        }
    }
}