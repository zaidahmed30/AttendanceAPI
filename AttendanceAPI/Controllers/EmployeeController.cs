using AttendanceAPI.Models;
using AttendanceAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeService.GetEmployees();
        }

        [HttpPost]
        public ActionResult<Employee> PostEmployee(Employee employee)
        {
            Employee model = new()
            {
                Id = employee.Id,
                EmployeeName = employee.EmployeeName,
                EmployeeCode = employee.EmployeeCode,
                Role = employee.Role
            };

            return _employeeService.PostEmployee(model);
        }
    }
}
