using KaffeMaskineSystem.Models;
using KaffeMaskineSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KaffeMaskineSystem.Services
{
    public class CleaningService
    {
        private readonly ICleaningRepository _cleaningRepository;

        public CleaningService(ICleaningRepository cleaningRepository)
        {
            _cleaningRepository = cleaningRepository;
        }

        public async Task<List<Cleaning>> GetAllCleaningsAsync()
        {
            return await _cleaningRepository.GetAllCleaningsAsync();
        }

        public async Task<Cleaning> GetCleaningByIdAsync(int cleaningId)
        {
            return await _cleaningRepository.GetCleaningByIdAsync(cleaningId);
        }

        public async Task<Cleaning> AddCleaningAsync(int coffeeMachineId, string cleanedBy, DateTime cleaningDate)
        {
            var cleaning = new Cleaning(coffeeMachineId, cleanedBy, cleaningDate);
            return await _cleaningRepository.AddCleaningAsync(cleaning);
        }

        public async Task<Cleaning> UpdateCleaningAsync(Cleaning cleaning)
        {
            return await _cleaningRepository.UpdateCleaningAsync(cleaning);
        }

        public async Task DeleteCleaningAsync(int cleaningId)
        {
            await _cleaningRepository.DeleteCleaningAsync(cleaningId);
        }
    }
}

