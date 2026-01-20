using AttendanceAPI.Models;
using AttendanceAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly IAttendanceService _attendanceService;
        public AttendanceController(IAttendanceService attendanceService)
        {
            _attendanceService = attendanceService;
        }

        [HttpGet]
        public IEnumerable<Attendance> GetAttendance()
        {
            return _attendanceService.GetAttendance();
        }

        [HttpGet("{employeeId}")]
        public IEnumerable<Attendance> GetAttendanceByEmployeeId(int employeeId)
        {
            return _attendanceService.GetAttendanceByEmployeeId(employeeId);
        }

        [HttpPost]
        public ActionResult<Attendance> PostAttendance(Attendance attendance)
        {
            Attendance model2 = new()
            {
                LoginTime = attendance.LoginTime,
                LogoutTime = attendance.LogoutTime,
                Date = attendance.Date,
                TotalWorkingHours = attendance.TotalWorkingHours,
                EmployeeId = attendance.EmployeeId
            };

            return _attendanceService.PostAttendance(model2);
        }

        [HttpPut]
        public ActionResult<Attendance> UpdateAttendance(int id, Attendance attendance)
        {
            _attendanceService.UpdateAttendance(id, attendance);
            return attendance;
        }
    }
}
