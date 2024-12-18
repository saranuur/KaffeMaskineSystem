namespace KaffeMaskineSystem.Models
{
    public class History
    {
        public int HistoryID { get; set; }        
        public int CoffeeMachineID { get; set; }          
        public string Description { get; set; }   
        public DateTime Date { get; set; }        

        public History() { }
        
        public History(int historyID, int coffeeMachineID, int userID, string description, DateTime date)
        {
            HistoryID = historyID;
            CoffeeMachineID = coffeeMachineID;
            Description = description;
            Date = date;
        }
    }
}
