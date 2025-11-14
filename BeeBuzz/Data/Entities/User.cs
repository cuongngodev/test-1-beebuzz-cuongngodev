using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BeeBuzz.Data.Entities
{
    public class User: IdentityRole<int>
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
     
        public string Age { get; set; }

        public List<Beehive>? beehives { get; set; } = new List<Beehive>();

    }
}
