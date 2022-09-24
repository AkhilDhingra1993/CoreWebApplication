using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CoreWebApplication.Models
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
            new User
            {
                ID = 4,
                FIRST_NAME = "Jyoti",
                LAST_NAME = "Dhingra",
                EMAIL = "jyoti@gmail.com",
                PASSWORD = "321"
            },
            new User
            {
                ID = 5,
                FIRST_NAME = "Mukesh",
                LAST_NAME = "Dhingra",
                EMAIL = "mukesh@gmail.com",
                PASSWORD = "546"
            }
            );
        }
    }
}
