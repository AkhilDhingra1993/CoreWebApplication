using System.Collections.Generic;
using System;
using System.Linq;

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
                }
            };
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userList;
        }

        public User GetUser(int ID) => _userList.FirstOrDefault(u => u.ID == ID);
    }
}
