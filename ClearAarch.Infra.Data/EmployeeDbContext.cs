using ClearArch.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace ClearAarch.Infra.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>()
                   .HasData(
                       new Employee { Id = 1, FirstName = "Ramzan", LastName = "Khan", Designatin = "Software" },
                       new Employee { Id = 2, FirstName = "Tariq", LastName = "Khan", Designatin = "Doctor" },
                       new Employee { Id = 3, FirstName = "javid", LastName = "Khan", Designatin = "Teacher" },
                       new Employee { Id = 4, FirstName = "Anaytullah", LastName = "Khan", Designatin = "Driver" } 


                   );
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
