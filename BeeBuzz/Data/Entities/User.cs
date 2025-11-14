namespace BeeBuzz.Data.Entities;
using System.ComponentModel.DataAnnotations;

public class User
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
