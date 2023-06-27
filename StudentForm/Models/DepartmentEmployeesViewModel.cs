using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForm.Models
{
    public class DepartmentEmployeesViewModel
    {
        public Department Department { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
