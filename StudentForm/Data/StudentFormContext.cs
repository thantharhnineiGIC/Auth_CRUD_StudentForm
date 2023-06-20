using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentForm.Models
{
    public class StudentFormContext : DbContext
    {
        public StudentFormContext (DbContextOptions<StudentFormContext> options)
            : base(options)
        {
        }

        public DbSet<StudentForm.Models.Student> Student { get; set; }
    }
}
