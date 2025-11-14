using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BeeBuzz.Data.Repositories
{
    public class UserRepository : BeeBuzzGenericGenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext db, ILogger<BeeBuzzGenericGenericRepository<User>> logger) : base(db, logger)
        {

        }
    }

}
