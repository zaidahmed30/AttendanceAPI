using AttendanceAPI.Context;
using AttendanceAPI.Models;

namespace AttendanceAPI.Services
{
    public class UserService : IUserService
    {
        UserContext _context;
        public UserService(UserContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public User PostUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
    }
}
