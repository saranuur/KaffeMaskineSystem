using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KaffeMaskineSystem.Models
{
    public class TubeChange
    {
        [Key]
        public int TubeChangeID { get; set; }

        [ForeignKey("CoffeeMachine")]
        public int CoffeeMachineID { get; set; }
        public CoffeeMachine CoffeeMachine { get; set; }

        public DateTime ChangeDate { get; set; }       

        [Required]
        [MaxLength(100)]
        public string ChangedBy { get; set; }

        public TubeChange() { }
        // Konstruktør til TubeChange
        public TubeChange(int tubeChangeID, DateTime changeDate, int userID, int coffeeMachineID, string changedBy)
        {
            TubeChangeID = tubeChangeID;
            ChangeDate = changeDate;
            CoffeeMachineID = coffeeMachineID;
            ChangedBy = changedBy;

        }
    }
}
