using AttendanceAPI.Models;
using AttendanceAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly IAttendanceService _attendanceService;

        public LoginController(ILoginService loginService, IAttendanceService attendanceService)
        {
            _loginService = loginService;
            _attendanceService = attendanceService;
        }

        [HttpPost]
        public ActionResult<User> Login(int employeeId, User user)
        {
            var user1 = _loginService.Login(employeeId,user);

            if (user1 == null)
            {
                return BadRequest("Invalid Username or Password");
            }
            var attendance = new Attendance
            {
                EmployeeId = employeeId,
                Date = DateTime.Now.Date
            };

            var created = _attendanceService.PostAttendance(attendance);

            return Ok(user1);
        }

       [HttpPatch("{id}")]
        public ActionResult Logout(int id)
        {
            var updated = _attendanceService.UpdateAttendance(id, null);
            if (updated == null)
            {
                return NotFound("No active login/attendance record found for this employee.");
            }

            return Ok(updated);
        }
    }
}
