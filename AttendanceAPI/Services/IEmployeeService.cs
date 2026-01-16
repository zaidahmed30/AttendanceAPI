using AttendanceAPI.Models;

namespace AttendanceAPI.Services
{
    public interface IEmployeeService
    {
        public IEnumerable<Employee> GetEmployees();
        public Employee PostEmployee(Employee employee);
    }
}
