using System.ComponentModel.DataAnnotations;

namespace BeeBuzz.Data.Entities
{
    public class Orgnanization
    {
        [Required]
        public int Id { get; set; } // provide by the government
        public List<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(300)]
        public string Description { get; set; }

    }
}
