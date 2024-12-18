using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KaffeMaskineSystem.Models
{
    public class Refill
    {
        [Key]
        public int RefillID { get; set; }


        [Required]
        public DateTime RefillDate { get; set; }


        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }


        [ForeignKey("CoffeeMachine")]
        public int CoffeeMachineID { get; set; }
        public CoffeeMachine CoffeeMachine { get; set; }

        public int CoffeeAmount { get; set; }
        public int SugarAmount { get; set; }
        public int MilkPowderAmount { get; set; }


        public Refill() { }

        // Refill Constructor
        public Refill(DateTime refillDate, int userID, int coffeeMachineID,
                      int coffeeAmount, int sugarAmount, int milkPowderAmount)
        {
            RefillDate = refillDate;
            UserID = userID;
            CoffeeMachineID = coffeeMachineID;
            CoffeeAmount = coffeeAmount;
            SugarAmount = sugarAmount;
            MilkPowderAmount = milkPowderAmount;
        }
    }
}
