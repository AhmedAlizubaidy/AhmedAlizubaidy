using EmployeeCenter.Database.Entitie;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCenter.Database
{
    public class DatabaseContext: DbContext
    {
        public DbSet<Employee> UsersEmployee { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-PIO3E7J\SQLEXPRESS; Initial Catalog=employee;Integrated  Security=True;");
        }
     
    }
}
