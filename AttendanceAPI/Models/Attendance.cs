using System.ComponentModel.DataAnnotations.Schema;

namespace AttendanceAPI.Models
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime LogoutTime { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalWorkingHours { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }
    }
}
