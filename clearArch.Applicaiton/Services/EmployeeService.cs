using System.Collections.Generic;
using clearArch.Applicaiton.Interfaces;
using clearArch.Applicaiton.ViewModals;
using ClearArch.Domain.Interfaces;

namespace clearArch.Applicaiton.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        public EmployeeViewModal GetEmployees()
        {
            return new EmployeeViewModal()
            {
                Employees = _employeeRepository.GetEmployees()
            };
        }
    }
}