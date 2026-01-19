using System.ComponentModel.DataAnnotations.Schema;

namespace AttendanceAPI.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public int Password { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }
    }
}
