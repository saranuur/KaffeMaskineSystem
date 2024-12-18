using System.ComponentModel.DataAnnotations;

namespace KaffeMaskineSystem.Models
{
    public class CoffeeMachine
    {
        [Key]
        public int CoffeeMachineID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Location { get; set; }

        public int WaterLevel { get; set; }
        public int CoffeeBeansLevel { get; set; }
        public int MilkPowderLevel { get; set; }
        public int SugarLevel { get; set; }

        public CoffeeMachine() { }

        public CoffeeMachine(string location, int waterLevel, int coffeeBeansLevel, int milkPowderLevel, int sugarLevel)
        {
            Location = location;
            WaterLevel = waterLevel;
            CoffeeBeansLevel = coffeeBeansLevel;
            MilkPowderLevel = milkPowderLevel;
            SugarLevel = sugarLevel;
        }
    }
}
