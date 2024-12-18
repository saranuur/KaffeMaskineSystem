using KaffeMaskineSystem.Models;
using KaffeMaskineSystem.Repositories;
using KaffeMaskineSystem.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KaffeMaskineSystem.Services
{
    public class CoffeeMachineService
    {
        private readonly ICoffeeMachineRepository _coffeeMachineRepository;

        public CoffeeMachineService(ICoffeeMachineRepository coffeeMachineRepository)
        {
            _coffeeMachineRepository = coffeeMachineRepository;
        }

        public Task<List<CoffeeMachine>> GetAllCoffeeMachinesAsync()
        {
            return _coffeeMachineRepository.GetAllCoffeeMachinesAsync();
        }

        public Task<CoffeeMachine> GetCoffeeMachineByIdAsync(int coffeeMachineId)
        {
            return _coffeeMachineRepository.GetCoffeeMachineByIdAsync(coffeeMachineId);
        }

        public Task<CoffeeMachine> AddCoffeeMachineAsync(CoffeeMachine coffeeMachine)
        {
            return _coffeeMachineRepository.AddCoffeeMachineAsync(coffeeMachine);
        }

        public Task<CoffeeMachine> UpdateCoffeeMachineAsync(CoffeeMachine coffeeMachine)
        {
            return _coffeeMachineRepository.UpdateCoffeeMachineAsync(coffeeMachine);
        }

        public Task DeleteCoffeeMachineAsync(int coffeeMachineId)
        {
            return _coffeeMachineRepository.DeleteCoffeeMachineAsync(coffeeMachineId);
        }
    }
}
