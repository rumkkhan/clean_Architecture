using ClearArch.Domain;
using ClearArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearAarch.Infra.Data.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeeDbContext _etx;

        public EmployeeRepository(EmployeeDbContext ctx)
        {
            _etx = ctx;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _etx.Employees;
        }
    }
}
