using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KaffeMaskineSystem.Models
{
    public class Notification
    {
        [Key]
        public int NotificationID { get; set; }

        [ForeignKey("CoffeeMachine")]
        public int CoffeeMachineID { get; set; }
        public CoffeeMachine CoffeeMachine { get; set; }

        [Required]
        [MaxLength(50)]
        public string NotificationType { get; set; }

        [Required]
        public DateTime NotificationDate { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }

    
        public Notification() { }

        // Notification constructor
        public Notification(int coffeeMachineID, string notificationType,
                            DateTime notificationDate, int userID)
        {
            CoffeeMachineID = coffeeMachineID;
            NotificationType = notificationType;
            NotificationDate = notificationDate;
            UserID = userID;
        }
    }
}
