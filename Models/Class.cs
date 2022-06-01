namespace TestSalarySystem.Models
{
    public class Class
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Type { get; set; }

        public Tutor? Tutor { get; set; }
    }
}
