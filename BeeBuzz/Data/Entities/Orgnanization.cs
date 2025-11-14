using System.ComponentModel.DataAnnotations;

namespace BeeBuzz.Data.Entities
{
    public class Orgnanization
    {
        [Required]
        public int Id { get; set; } // provide by the government
        public List<User> Users { get; set; } = new List<User>();
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(300)]
        public string Description { get; set; }

    }
}
