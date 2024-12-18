using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KaffeMaskineSystem.Models
{
    public class Cleaning
    {
        [Key]
        public int CleaningID { get; set; }

        [ForeignKey("CoffeeMachine")]
        public int CoffeeMachineID { get; set; }
        public CoffeeMachine CoffeeMachine { get; set; }

        [Required]
        [MaxLength(100)]
        public string CleanedBy { get; set; }

        [Required]
        public DateTime CleaningDate { get; set; }

       
        public Cleaning() { }

        // Cleaning constructor
        public Cleaning(int coffeeMachineID, string cleanedBy, DateTime cleaningDate)
        {
            CoffeeMachineID = coffeeMachineID;
            CleanedBy = cleanedBy;
            CleaningDate = cleaningDate;
        }
    }
}



