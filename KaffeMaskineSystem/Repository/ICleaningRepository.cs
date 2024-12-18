using KaffeMaskineSystem.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KaffeMaskineSystem.Repositories
{
    public interface ICleaningRepository
    {
        Task<List<Cleaning>> GetAllCleaningsAsync();
        Task<Cleaning> GetCleaningByIdAsync(int cleaningId);
        Task<Cleaning> AddCleaningAsync(Cleaning cleaning);
        Task<Cleaning> UpdateCleaningAsync(Cleaning cleaning);
        Task DeleteCleaningAsync(int cleaningId);
    }
}
