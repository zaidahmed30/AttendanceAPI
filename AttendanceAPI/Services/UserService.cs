using AttendanceAPI.Context;
using AttendanceAPI.Models;
using AttendanceAPI.Models.DTOs;

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

        public User PostUser(UserDTO userDTO)
        {
            var user = new User
            {
                UserId = userDTO.UserId,
                Username = userDTO.Username,
                Password = userDTO.Password,
                EmployeeId = userDTO.EmployeeId
            };
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
    }
}
