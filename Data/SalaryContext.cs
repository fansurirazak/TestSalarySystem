using TestSalarySystem.Models;
using Microsoft.EntityFrameworkCore;

namespace TestSalarySystem.Data
{
    public class SalaryContext:DbContext
    {
        public SalaryContext(DbContextOptions<SalaryContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Performance> Performances { get; set; }

        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Tutor>().ToTable("Tutor");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Admin>().ToTable("Admin");
            modelBuilder.Entity<Class>().ToTable("Class");
            modelBuilder.Entity<Performance>().ToTable("Performance");
            modelBuilder.Entity<Salary>().ToTable("Salary");
            modelBuilder.Entity<Status>().ToTable("Statuses");
            modelBuilder.Entity<User>().ToTable("Users");

        }

        public DbSet<TestSalarySystem.Models.User>? User { get; set; }
    }
}
