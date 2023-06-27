using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentForm.Models;

namespace StudentForm.Data
{
    public class DepartmentDbContext : DbContext
    {
        public DepartmentDbContext (DbContextOptions<DepartmentDbContext> options)
            : base(options)
        {
        }

        public DbSet<StudentForm.Models.Department> Department { get; set; }
    }
}
