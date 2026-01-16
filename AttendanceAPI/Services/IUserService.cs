using AttendanceAPI.Models;

namespace AttendanceAPI.Services
{
    public interface IUserService
    {
        public IEnumerable<User> GetUsers();
        public User PostUser(User user);
    }
}
