namespace TestSalarySystem.Models
{
    public class Batch
    {
        public int ID { get; set; }

        public DateTime CreateDate { get; set; }

        
        public ICollection<Student>? Students { get; set; }
        //public Tutor? Tutor { get; set; }
    }
}
