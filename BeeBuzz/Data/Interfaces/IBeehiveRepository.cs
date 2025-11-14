using BeeBuzz.Data.Entities;

namespace BeeBuzz.Data.Interfaces
{
    public interface IBeehiveRepository : IBeeBuzzGenericRepository<Beehive>
    {
        IEnumerable<Beehive> GetAll();

    }
}
