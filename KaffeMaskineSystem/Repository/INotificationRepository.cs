using KaffeMaskineSystem.Models;

namespace KaffeMaskineSystem.Repository
{
    public interface INotificationRepository
    {
        Task<IEnumerable<Notification>> GetAllNotificationsAsync();
        Task<Notification> GetNotificationByIdAsync(int id);
        Task AddNotificationAsync(Notification notification);
        Task UpdateNotificationAsync(Notification notification);
        Task DeleteNotificationAsync(int id);
    }
}
