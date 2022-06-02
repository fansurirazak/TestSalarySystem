namespace TestSalarySystem.Models
{
    public class Performance
    {
        public int ID { get; set; }
        public string? Remark { get; set; }

        public Student Student { get; set; } = null!;
    }
}
