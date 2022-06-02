

namespace TestSalarySystem.Models
{

    public enum Gender
    {
        Lelaki, Perempuan
    }

    public enum State
    {
        Aktif, TidakAktif
    }

    public class Tutor
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public string IC { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public string Password { get; set; } = null!;
        public Gender Gender { get; set; }
        public State Status { get; set; }

        public ICollection<Class>? ClassList { get; set; }
        public ICollection<Salary>? SalaryList { get; set; }

        public Batch? Batch { get; set; }
    }
}
