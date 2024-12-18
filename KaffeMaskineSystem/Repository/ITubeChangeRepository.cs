using KaffeMaskineSystem.Models;

namespace KaffeMaskineSystem.Repository
{
    public interface ITubeChangeRepository
    {
        Task<IEnumerable<TubeChange>> GetAllChangesAsync();
        Task<TubeChange> GetChangeByIdAsync(int id);
        Task AddChangeAsync(TubeChange change);
        Task UpdateChangeAsync(TubeChange change);
        Task DeleteChangeAsync(int id);
    }
}
