using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public String DepartmentName { get; set; }

        public static implicit operator Department(int v)
        {
            throw new NotImplementedException();
        }
    }
}
