using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TestSalarySystem.Models
{
    public class Salary
    {
        [Key]
        public int ID { get; set; }

        public DateTime PayDate { get; set; }
        public DateTime DueDate { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public Tutor? Tutor { get; set; }
    }
}
