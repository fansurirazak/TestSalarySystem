namespace TestSalarySystem.Models
{
    public class User
    {

        public int Id { get; set; }
        public string IC { get; set; } = null!;
        public string Name { get; set; } = null!;

        public string Password { get; set; } = null!;
        public int Role { get; set; }
    }
}
