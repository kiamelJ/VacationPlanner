using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace VacationPlanner.Models
{
    public class VPContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Vacation> Vacations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmpId = 7,
                    Name = "Micke"
                },
                new Employee
                {
                    EmpId = 5,
                    Name = "Anna"
                },
                new Employee
                {
                    EmpId = 6,
                    Name = "Gösta"
                }
                );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=.\sqlexpress; initial catalog=VacationPlanner; integrated security=sspi;");
        }

    }
}
