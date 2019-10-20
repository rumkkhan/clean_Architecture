using System;
using System.Collections.Generic;
using System.Text;

namespace ClearArch.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
    }
}
