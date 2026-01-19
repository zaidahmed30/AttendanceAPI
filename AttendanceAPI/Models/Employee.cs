//using AttendanceAPI.Migrations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AttendanceAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeCode { get; set; }
        public string Role { get; set; }
    }
}
