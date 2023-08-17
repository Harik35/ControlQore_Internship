using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeApplication.Model.Models;

namespace EmployeeApplication.Repository.Context
{
    public class EmployeeApplicationContext:DbContext
    {
        public EmployeeApplicationContext(DbContextOptions option): base(option) { }

        public DbSet<Location> locations { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> department { get; set; }

        
    }
}
