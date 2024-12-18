using KaffeMaskineSystem.Models;
using KaffeMaskineSystem.Repository;

namespace KaffeMaskineSystem.Services
{
    public class NotificationService
    {
        private readonly INotificationRepository _repository;

        public NotificationService(INotificationRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Notification>> GetAllNotificationsAsync()
        {
            return await _repository.GetAllNotificationsAsync();
        }

        public async Task<Notification> GetNotificationByIdAsync(int id)
        {
            return await _repository.GetNotificationByIdAsync(id);
        }

        public async Task AddNotificationAsync(Notification notification)
        {
            await _repository.AddNotificationAsync(notification);
        }

        public async Task UpdateNotificationAsync(Notification notification)
        {
            await _repository.UpdateNotificationAsync(notification);
        }

        public async Task DeleteNotificationAsync(int id)
        {
            await _repository.DeleteNotificationAsync(id);
        }
    }
}