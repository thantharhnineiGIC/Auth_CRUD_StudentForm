using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForm.Data
{
    public class CalculateDbContext : DbContext
    {
        public CalculateDbContext(DbContextOptions<CalculateDbContext> options)
            : base(options)
        {
        }

        public DbSet<StudentForm.Models.Calculate> Calculate { get; set; }
    }
}
