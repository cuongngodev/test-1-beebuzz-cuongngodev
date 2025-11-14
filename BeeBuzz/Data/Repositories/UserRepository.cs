using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Interfaces;

namespace BeeBuzz.Data.Repositories
{
    public class UserRepository : BeeBuzzGenericGenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext db, ILogger<BeeBuzzGenericGenericRepository<User>> logger) : base(db, logger)
        {

        }
    }

}
