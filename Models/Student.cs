using System;
using System.Collections.Generic;

namespace TestSalarySystem.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public DateTime Date { get; set; }

        public string? Package { get; set; } 

        public int Days { get; set; }

        public string? BatchNumber { get; set; }
 //might want to change this to enum later on.

        public Batch? Batch { get; set; }
        public Status? Status { get; set; }
    }
}
