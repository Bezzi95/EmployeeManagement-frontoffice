using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Model
{
    public class Employee

    {

        public int EmployeeId { get; set; }
        [Required]
      

        public String FirstName { get; set; }
        [Required]
        public String LastName { get; set; }

        public String Email { get; set; }

        public DateTime DatofBirth { get; set; }

        public Gender Gender { get; set; }

        public int DepartmentId { get; set; }

        public String PhotoPath { get; set; }

        public Department Department { get; set; }
        public DateTime DateOfBrith { get; set; }
    }
}
