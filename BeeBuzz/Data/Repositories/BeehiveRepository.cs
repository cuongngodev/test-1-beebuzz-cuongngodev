using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Interfaces;

namespace BeeBuzz.Data.Repositories
{
    public class BeehiveRepository : BeeBuzzGenericGenericRepository<Beehive>, IBeehiveRepository 
    {
        public BeehiveRepository(ApplicationDbContext db, ILogger<BeeBuzzGenericGenericRepository<Beehive>> logger) : base(db, logger)
        {

        }
    }
}
