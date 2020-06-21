using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ex1.Models;

namespace Ex1.Data
{
    public class Ex1Context : DbContext
    {
        public Ex1Context (DbContextOptions<Ex1Context> options)
            : base(options)
        {
        }

        public DbSet<Ex1.Models.Department> Department { get; set; }
    }
}
