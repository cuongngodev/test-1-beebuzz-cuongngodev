using System.ComponentModel.DataAnnotations;

namespace BeeBuzz.Data.Entities
{
    public class Orgnanization
    {
    
        public string Id { get; set; } // provide by the government
        public List<User> Users { get; set; } = new List<User>();
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
