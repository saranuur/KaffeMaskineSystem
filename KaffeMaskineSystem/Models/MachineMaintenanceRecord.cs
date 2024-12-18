using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace KaffeMaskineSystem.Models
{
    public class MachineMaintenanceRecord
    {
        [Key]
        public int MachineMaintenanceRecordID { get; set; }

        [ForeignKey("CoffeeMachine")]
        public int CoffeeMachineID { get; set; }
        public CoffeeMachine CoffeeMachine { get; set; }

        [Required]
        [MaxLength(255)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(50)]
        public string EventType { get; set; }

        [Required]
        public DateTime EventDate { get; set; }
    }
}
