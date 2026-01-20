using AttendanceAPI.Models;

namespace AttendanceAPI.Services
{
    public interface IAttendanceService
    {
        public IEnumerable<Attendance> GetAttendance();
        public IEnumerable<Attendance> GetAttendanceByEmployeeId(int employeeId);
        public Attendance PostAttendance(Attendance attendance);
        public Attendance UpdateAttendance(int id, Attendance attendance);
    }
}
