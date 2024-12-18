using KaffeMaskineSystem.Models;

namespace KaffeMaskineSystem.Repository
{
    public interface ICoffeeMachineRepository
    {
        Task<List<CoffeeMachine>> GetAllCoffeeMachinesAsync();
        Task<CoffeeMachine> GetCoffeeMachineByIdAsync(int coffeeMachineId);
        Task<CoffeeMachine> AddCoffeeMachineAsync(CoffeeMachine coffeeMachine);
        Task<CoffeeMachine> UpdateCoffeeMachineAsync(CoffeeMachine coffeeMachine);
        Task DeleteCoffeeMachineAsync(int coffeeMachineId);
    }
}
