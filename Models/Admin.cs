using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestSalarySystem.Models
{
    


    public class Admin
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        //public string RefNo { get; set; } = null!;

        public string? Contact { get; set; }

        public string Password { get; set; } = null!;

        public string IC { get; set; } = null!;

        //public UserType Role { get; set; }
    }
}
