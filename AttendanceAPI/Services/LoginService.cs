using AttendanceAPI.Context;
using AttendanceAPI.Models;

namespace AttendanceAPI.Services
{
    public class LoginService : ILoginService
    {
        UserContext _context;
        public LoginService(UserContext context)
        {
            _context = context;
        }
        public User Login(int employeeId, User user)
        {
            var username = user.Username;
            var password = user.Password;

            return _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
