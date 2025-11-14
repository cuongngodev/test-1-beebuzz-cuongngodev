using System.ComponentModel.DataAnnotations;

namespace BeeBuzz.Data.Entities
{
    public class Beehive
    {

        [Required]

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, StringLength(300)]

        public string Description { get; set; }

    }
}
