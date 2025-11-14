using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Interfaces;

namespace BeeBuzz.Data.Repositories
{
    public class OrganizationRepository : BeeBuzzGenericGenericRepository<Orgnanization>, IOrganizationRepository
    {
        public OrganizationRepository(ApplicationDbContext db, ILogger<BeeBuzzGenericGenericRepository<Orgnanization>> logger) : base(db, logger)
        {

        }
    }
   

}
