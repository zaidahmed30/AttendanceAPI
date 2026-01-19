using AttendanceAPI.Context;
using AttendanceAPI.Models;

namespace AttendanceAPI.Services
{
    public class AttendanceService : IAttendanceService
    {
        UserContext _context;

        public AttendanceService(UserContext context)
        {
            _context = context;
        }


        public IEnumerable<Attendance> GetAttendance()
        {
            return _context.Attendances.ToList();
        }

        public Attendance PostAttendance(Attendance attendance)
        {
            attendance.LoginTime = DateTime.Now;
            attendance.TotalWorkingHours = 0;
            _context.Attendances.Add(attendance);
            _context.SaveChanges();
            return attendance;
        }

        
        public Attendance UpdateAttendance(int id, Attendance attendance)
        {
            var record = _context.Attendances
                .Where(a => a.EmployeeId == id && a.LogoutTime == default(DateTime))
                .OrderByDescending(a => a.LoginTime)
                .FirstOrDefault();
            if (record != null)
            {
                record.LogoutTime = DateTime.Now;
                record.TotalWorkingHours = (decimal)(record.LogoutTime - record.LoginTime).TotalHours;
                _context.SaveChanges();
            }

            return record;
        }
    }
}
