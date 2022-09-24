using System.Collections.Generic;
using System.Threading;

namespace CoreWebApplication.Models
{
    public class SqlUserRepository : IUserRepostory
    {
        private readonly AppDbContext context;
        public SqlUserRepository(AppDbContext context)
        {
            this.context = context;
        }
        public User Add(User user)
        {
            context.User.Add(user);
            context.SaveChanges();
            return user;
        }
        public User Delete(long ID)
        {
            User user = context.User.Find(ID);
            if (user != null)
            {
                context.User.Remove(user);
                context.SaveChanges();
            }
            return user;
        }
        public IEnumerable<User> GetAllUsers()
        {
            return context.User;
        }
        public User GetUser(long ID)
        {
            return context.User.Find(ID);
        }
        public User Update(User user)
        {
            var User = context.User.Attach(user);
            User.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return user;
        }
    }
}
