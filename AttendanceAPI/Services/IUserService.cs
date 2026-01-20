using AttendanceAPI.Models;
using AttendanceAPI.Models.DTOs;

namespace AttendanceAPI.Services
{
    public interface IUserService
    {
        public IEnumerable<User> GetUsers();
        public User PostUser(UserDTO userDTO);
        //User PostUser(UserDTO userDTO);
    }
}
