using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Repositories;

namespace BeeBuzz.Data.Interfaces
{
    public interface IOrganizationRepository : IBeeBuzzGenericRepository<Orgnanization>
    {
        IEnumerable<User> GetAllUsers();
        IEnumerable<Beehive> GetAllBeehives();

    }
}
