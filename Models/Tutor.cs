

namespace TestSalarySystem.Models
{
    public class Tutor
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Gender { get; set; }
        public int Status { get; set; }

        public ICollection<Class>? ClassList { get; set; }
        public ICollection<Salary>? SalaryList { get; set; }
    }
}
