using AttendanceAPI.Context;
using AttendanceAPI.Models;
using System.Collections.Generic;

namespace AttendanceAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        UserContext _context;
        public EmployeeService(UserContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee PostEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }
    }
}
