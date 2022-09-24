using System.Collections;
using System.Collections.Generic;

namespace CoreWebApplication.Models
{
    public interface IUserRepostory
    {
        User GetUser(int ID);
        IEnumerable<User> GetAllUsers();
        User Add(User user);
        User Update(User user);
        User Delete(int ID);
    }
}