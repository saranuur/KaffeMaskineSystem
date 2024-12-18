using KaffeMaskineSystem.Data;
using KaffeMaskineSystem.Models;
using KaffeMaskineSystem.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KaffeMaskineSystem.Repositories
{
    public class CoffeeMachineRepository : ICoffeeMachineRepository
    {
        private readonly AppDbContext _context;

        public CoffeeMachineRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<CoffeeMachine>> GetAllCoffeeMachinesAsync()
        {
            return await _context.CoffeeMachines.ToListAsync();
        }

        public async Task<CoffeeMachine> GetCoffeeMachineByIdAsync(int coffeeMachineId)
        {
            return await _context.CoffeeMachines.FindAsync(coffeeMachineId);
        }

        public async Task<CoffeeMachine> AddCoffeeMachineAsync(CoffeeMachine coffeeMachine)
        {
            _context.CoffeeMachines.Add(coffeeMachine);
            await _context.SaveChangesAsync();
            return coffeeMachine;
        }

        public async Task<CoffeeMachine> UpdateCoffeeMachineAsync(CoffeeMachine coffeeMachine)
        {
            _context.CoffeeMachines.Update(coffeeMachine);
            await _context.SaveChangesAsync();
            return coffeeMachine;
        }

        public async Task DeleteCoffeeMachineAsync(int coffeeMachineId)
        {
            var coffeeMachine = await _context.CoffeeMachines.FindAsync(coffeeMachineId);
            if (coffeeMachine != null)
            {
                _context.CoffeeMachines.Remove(coffeeMachine);
                await _context.SaveChangesAsync();
            }
        }
    }
}
