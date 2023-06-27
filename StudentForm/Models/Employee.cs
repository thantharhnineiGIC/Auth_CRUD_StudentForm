using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForm.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        public int Band { get; set; }

        public Department Department { get; set; }
    }
}
