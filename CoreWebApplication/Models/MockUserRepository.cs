using System.Collections.Generic;
using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace CoreWebApplication.Models
{
    public class MockUserRepository : IUserRepostory
    {
        private readonly List<User> _userList;

        public MockUserRepository()
        {
            _userList = new List<User>()
            {
                new User()
                {
                    ID =1,
                    EMAIL ="dhingra93akhil@gmail.com",
                    FIRST_NAME = "Akhil",
                    MIDDLE_NAME ="Kumar",
                    LAST_NAME ="Dhingra",
                    PASSWORD ="cricket@1",
                    IS_DELETED = false,
                    IS_ACTIVE =true,
                },
                new User()
                {
                    ID =2,
                    EMAIL ="aayushithani@gmail.com",
                    FIRST_NAME = "Aayushi",
                    MIDDLE_NAME ="",
                    LAST_NAME ="Thani",
                    PASSWORD ="secret@@19",
                    IS_DELETED = false,
                    IS_ACTIVE =true,
                }
            };
        }

        public User Add(User user)
        {
            user.ID = _userList.Max(u => u.ID) + 1;
            _userList.Add(user);
           
            return user;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userList;
        }

        public User GetUser(int ID) => _userList.FirstOrDefault(u => u.ID == ID);
    }
}
