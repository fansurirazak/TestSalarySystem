using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TestSalarySystem.Models
{
    public class Status
    {
        
        [Key]
        public int StudentID { get; set; }
        public int TutorID { get; set; }
        public string? status { get; set; }  

        public Student? Student { get; set; }
        public Tutor? Tutor { get; set; }
    }
}
