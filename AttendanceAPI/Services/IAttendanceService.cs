using AttendanceAPI.Models;

namespace AttendanceAPI.Services
{
    public interface IAttendanceService
    {
        public IEnumerable<Attendance> GetAttendance();
        public Attendance PostAttendance(Attendance attendance);
        public Attendance UpdateAttendance(int id, Attendance attendance);
    }
}
