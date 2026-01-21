using AttendanceAPI.Models;

namespace AttendanceAPI.Services
{
    public interface ILoginService
    {
        public User Login(User user);
    }
}
