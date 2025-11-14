using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BeeBuzz.Data.Entities
{
    /// <summary>
    /// User entity
    /// </summary>
    public class ApplicationUser : IdentityUser<int>
    {
        [Required]
        public int UserId { get; set; }
        [Required, StringLength(50)]
        public string FirstName { get; set; }
        [Required, StringLength(50)]
        public string LastName { get; set; }
        [Range(10, 100)]
        public string Age { get; set; }
    }
}
