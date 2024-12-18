using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KaffeMaskineSystem.Models
{
    public class TrayEmptyingRecord
    {
        [Key]
        public int TrayEmptyingRecordID { get; set; }

        [ForeignKey("CoffeeMachine")]
        public int CoffeeMachineID { get; set; }
        public CoffeeMachine CoffeeMachine { get; set; }

        [Required]
        [MaxLength(255)]
        public string UserName { get; set; }

        [Required]
        public DateTime TimeEmptied { get; set; }
    }
}

