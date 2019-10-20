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

        public DbSet<Employee> Employees { get; set; }
    }
}
