using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBook.Models
{
    public class User:IdentityUser
    {
    [Key]
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string TelNo { get; set; }
    [Required]
    public string Password { get; set; }
    
    public DateTime? BirthDate { get; set; }
  }
}
