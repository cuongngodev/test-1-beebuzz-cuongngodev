using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Interfaces;
using BeeBuzz.Data.Entities;

namespace BeeBuzz.Data.Repositories
{
    public class OrganizationRepository : BeeBuzzGenericGenericRepository<Orgnanization>, IOrganizationRepository
    {
        public OrganizationRepository(ApplicationDbContext db, ILogger<BeeBuzzGenericGenericRepository<Orgnanization>> logger) : base(db, logger)
        {

        }
        public IEnumerable<User> GetAllUsers()
        {
            //return _dbSet.ToList();
        }
    }
   

}
